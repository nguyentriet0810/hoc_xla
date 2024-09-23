##programmed by nhom 1 lop xu ly anh thu 2 tiet 4-6 
##Nguyen Hoang Minh Triet - 21151176
##Phan Duy Kien - 21151122
##============================================================================

## khai bao thu vien
## thu vien opencv
import cv2
## thu vien numpy dung de tinh toan
import numpy as np
## thu vien pillow ho tro
from PIL import Image
##thu vien tinh toan
import math

##khai bao mat na Sobel
##mat na sobel theo phuong x
sobelx = [[-1,-2,-1],
          [ 0, 0, 0],
          [ 1, 2, 1]]
##mat na sobel theo phuong y
sobely = [[-1, 0, 1],
          [-2, 0, 2],
          [-1, 0, 1]]

##ham nhan dang duong bien dung sobel
def NhanDangDuongBien(RGBImage, threshold):

    ##lay kich thuoc anh
    width = RGBImage.size[0]
    height = RGBImage.size[1]

    ##tao bien chua hinh anh cung mode va kich thuc
    newimage = Image.new(RGBImage.mode, RGBImage.size)

    ##quet anh tu trai sang phai tu tren xuong duoi
    ##do khi tinh1 diem anh can co gia tri cua 8 diem xung quanh diem do
    ##nen cac diem anh o ngoai cung (cot 0 hang 0, hang 511, cot 511) cua khung hinh ko dap ung duoc yeu cau
    ##vi vay ta quet cac diem anh phia trong (bd tu cot 1 den cot 510, hang 1 den hang 510)
    for x in range(1, width - 1):
        for y in range(1, height - 1):
            
            ##lay gia tri cac diem anh co lien quan
            """
            [[R00, R01, R02],
             [R10, R11, R12],
             [R20, R21, R22]]
            Tuong tu voi cac kenh G B
            """
            R00, G00, B00 = RGBImage.getpixel((x-1, y-1))
            R01, G01, B01 = RGBImage.getpixel((x  , y-1))
            R02, G02, B02 = RGBImage.getpixel((x+1, y-1))
            R10, G10, B10 = RGBImage.getpixel((x-1, y))
            R11, G11, B11 = RGBImage.getpixel((x  , y))
            R12, G12, B12 = RGBImage.getpixel((x+1, y))
            R20, G20, B20 = RGBImage.getpixel((x-1, y+1))
            R21, G21, B21 = RGBImage.getpixel((x  , y+1))
            R22, G22, B22 = RGBImage.getpixel((x+1, y+1))

            ##tinh vector gradient teo cac phuong x y cua tung kenh mau
            ##nhan cac diem anh kenh red voi mat na sobel 
            gxR = R00*sobelx[0][0] + R01*sobelx[0][1] + R02*sobelx[0][2] + R10*sobelx[1][0] + R11*sobelx[1][1] + R12*sobelx[1][2] + R20*sobelx[2][0] + R21*sobelx[2][1] + R22*sobelx[2][2]
            gyR = R00*sobely[0][0] + R01*sobely[0][1] + R02*sobely[0][2] + R10*sobely[1][0] + R11*sobely[1][1] + R12*sobely[1][2] + R20*sobely[2][0] + R21*sobely[2][1] + R22*sobely[2][2]
            ##nhan cac diem anh kenh green voi mat na sobel
            gxG = G00*sobelx[0][0] + G01*sobelx[0][1] + G02*sobelx[0][2] + G10*sobelx[1][0] + G11*sobelx[1][1] + G12*sobelx[1][2] + G20*sobelx[2][0] + G21*sobelx[2][1] + G22*sobelx[2][2]
            gyG = G00*sobely[0][0] + G01*sobely[0][1] + G02*sobely[0][2] + G10*sobely[1][0] + G11*sobely[1][1] + G12*sobely[1][2] + G20*sobely[2][0] + G21*sobely[2][1] + G22*sobely[2][2]
            ##nhan cac diem anh kenh blue voi mat na sobel 
            gxB = B00*sobelx[0][0] + B01*sobelx[0][1] + B02*sobelx[0][2] + B10*sobelx[1][0] + B11*sobelx[1][1] + B12*sobelx[1][2] + B20*sobelx[2][0] + B21*sobelx[2][1] + B22*sobelx[2][2]
            gyB = B00*sobely[0][0] + B01*sobely[0][1] + B02*sobely[0][2] + B10*sobely[1][0] + B11*sobely[1][1] + B12*sobely[1][2] + B20*sobely[2][0] + B21*sobely[2][1] + B22*sobely[2][2]
            
            ##tinh tich cua cac vector
            gxx = gxR*gxR + gxG*gxG + gxB*gxB
            gyy = gyR*gyR + gyG*gyG + gyB*gyB
            ##do 2 ham tren ko cho ra gtri am ma ham nay thi co nen khi tinh toan ve sau ta lay gia tri tuyet  doi cua no
            gxy = math.fabs(gxR*gyR + gxG*gyG + gxB*gyB)
            
            ##tinh goc quay theta
            ##tu so
            tu = 2 * gxy
            ##mau so
            mau = gxx - gyy
            ##truong hop mau so = 0 => cos(theta) = 0
            if mau == 0:
                theta = math.pi/2
            ##cac truong hop con lai tinh theo cong thuc
            else:
                theta = (1 / 2) * math.atan(tu / mau)
                ##do tinh chat tan(theta) = tan(theta +- pi) nen goc = theta +- pi/2
                ##ta gioi han mien lam viec cua theta trong khoang nua mo [0;pi) (goc phan tu 1 va 2)
                if theta < 0:
                    theta = theta + math.pi/2

            ##tinh do lon ham so
            ##tinh cac phan tu trong ham so
            a = gxx + gyy
            b = gxx - gyy 
            c = math.cos((2 * theta))
            d = 2 * gxy * math.sin((2 * theta))
            ##tinh ham so F theo cong thuc
            F = math.sqrt((1 / 2)*(a + b * c + d))

            ##so sanh voi gia tri nguong
            if F <= threshold:
                ##diem P(x,y) thuoc background
                F = 0
            else:
                ##diem P(x,y) thuoc edge
                F = 255
            
            ##gan gia tri diem anh vao anh
            newimage.putpixel((x,y),( F, F, F))
    
    ##tra anh ve
    return newimage

##chuong trinh chinh
def main():

    ## tao link cho hinh can xu ly
    hinh = r'lena_color.png'
	
    ## doc anh dung thu vien dung opencv
    img = cv2.imread(hinh, cv2.IMREAD_COLOR)

    ##doc hinh dung thu vien PIL thay vi dung opencv
    imgPIL = Image.open(hinh)

    ##doc ve anh da phan doan mau
    NEWImage = NhanDangDuongBien(imgPIL, 130)
    
    ##chuyen ve anh thuong
    NEWImage = np.array(NEWImage)
    
    ## hien thi hinh
    cv2.imshow('Hinh goc co gai lena', img)
    cv2.imshow('Nhan dang duong bien co gai lena', NEWImage)

	## thoat hinh bang cach nhan phim bat ki
    cv2.waitKey(0)

    ## xoa data
    cv2.destroyAllWindows()
    
if __name__ == "__main__" :
    main()