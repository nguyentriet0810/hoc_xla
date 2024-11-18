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
sobelx = [[-1,-2,-1],[ 0, 0, 0],[ 1, 2, 1]]
sobely = [[-1, 0, 1],[-2, 0, 2],[-1, 0, 1]]

##khai bao mat na Prewitt
prewittx = [[-1,-1,-1],[ 0, 0, 0],[ 1, 1, 1]]
prewitty = [[-1, 0, 1],[-1, 0, 1],[-1, 0, 1]]

##khai bao mat na Roberts
robertsx = [[-1, 0],[ 0, 1]]
robertsy = [[ 0,-1],[ 1, 0]]

##ham chuyen doi anh RGB sang grayscale
def RGBtoGrayscale(RGBImage, option):

    ##lay kich thuoc anh
    width = RGBImage.size[0]
    height = RGBImage.size[1]

    ##tao bien chua anh co cung mode va kich thuoc
    GrayImage = Image.new(RGBImage.mode, RGBImage.size)

    ##quet anh tu trai sang phai tu tren xuong duoi
    for x in range(width):
        for y in range(height):
            
            ##lay gia tri diem anh
            R, G, B = RGBImage.getpixel((x,y))

            ##chon option Average
            if option == 0:
                
                ##tinh gia tri muc xam thheo cong thuc average
                Gray = np.uint8((R + G + B) / 3)
            
            ##chon option Lightness
            elif option == 1:
                
                ##so sanh tim gia tri max min
                Max = max(R, G, B)
                Min = min(R, G, B)

                ##tinh theo cong thuc Lightness
                Gray = np.uint8((Max + Min) / 2)
            
            ##chon option Luminance
            elif option == 2:
                
                ##tinh tho cong thuc Luminance
                Gray = np.uint8((R*0.2126 + G*0.7152 + B*0.0722))


            ##gan gia tri vao diem anh
            GrayImage.putpixel((x,y),( Gray, Gray, Gray))
    
    ##tra ve anh xam
    return GrayImage

##ham tinh toan duong bien dung Sobel
def NhanDangDuongBien(GrayImage, option, threshold):
    ##lay kich thuoc anh
    width = GrayImage.size[0]
    height = GrayImage.size[1]

    ##tao bien chua hinh anh cung mode va kich thuc
    newimage = Image.new(GrayImage.mode, GrayImage.size)

    ##quet anh tu trai sang phai tu tren xuong duoi 
    for x in range(1, width - 1):
        for y in range(1, height - 1):
            
            ##lay gia tri cac diem anh
            R00, G00, B00 = GrayImage.getpixel((x-1, y-1))
            R01, G01, B01 = GrayImage.getpixel((x  , y-1))
            R02, G02, B02 = GrayImage.getpixel((x+1, y-1))
            R10, G10, B10 = GrayImage.getpixel((x-1, y))
            R11, G11, B11 = GrayImage.getpixel((x  , y))
            R12, G12, B12 = GrayImage.getpixel((x+1, y))
            R20, G20, B20 = GrayImage.getpixel((x-1, y+1))
            R21, G21, B21 = GrayImage.getpixel((x  , y+1))
            R22, G22, B22 = GrayImage.getpixel((x+1, y+1))

            ##tinh vector tai diem P(x,y)
            ##lua chon mat na sobel
            if option == "S":
                
                ##nhan cac diem anh voi mat na sobel anh xam nen lay 1 kenh thoi
                gx = R00*sobelx[0][0] + R01*sobelx[0][1] + R02*sobelx[0][2] + R10*sobelx[1][0] + R11*sobelx[1][1] + R12*sobelx[1][2] + R20*sobelx[2][0] + R21*sobelx[2][1] + R22*sobelx[2][2]
                gy = R00*sobely[0][0] + R01*sobely[0][1] + R02*sobely[0][2] + R10*sobely[1][0] + R11*sobely[1][1] + R12*sobely[1][2] + R20*sobely[2][0] + R21*sobely[2][1] + R22*sobely[2][2]
            
            ##lua chon mat na Prewitt 
            elif option == "P":
                
                ##nhan cac diem anh voi mat na Prewitt anh xam nen lay 1 kenh thoi
                gx = R00*prewittx[0][0] + R01*prewittx[0][1] + R02*prewittx[0][2] + R10*prewittx[1][0] + R11*prewittx[1][1] + R12*prewittx[1][2] + R20*prewittx[2][0] + R21*prewittx[2][1] + R22*prewittx[2][2]
                gy = R00*prewitty[0][0] + R01*prewitty[0][1] + R02*prewitty[0][2] + R10*prewitty[1][0] + R11*prewitty[1][1] + R12*prewitty[1][2] + R20*prewitty[2][0] + R21*prewitty[2][1] + R22*prewitty[2][2]
            
            ##lua chon mat na Roberts
            elif option == "R":
                
                ##nhan cac diem anh voi mat na Roberts anh xam nen lay 1 kenh thoi
                gx = R11*robertsx[0][0] + R12*robertsx[0][1] + R21*robertsx[1][0] + R22*robertsx[1][1]
                gy = R11*robertsy[0][0] + R12*robertsy[0][1] + R21*robertsy[1][0] + R22*robertsy[1][1]

            ##tinh do dai vector
            M = math.fabs(gx) + math.fabs(gy)

            ##so sanh voi gia tri nguong
            if M <= threshold:
                
                ##diem P(x,y) thuoc background
                M = 0
            else:

                ##diem P(x,y) thuoc edge
                M = 255
            
            ##gan gia tri vao diem anh
            newimage.putpixel((x,y),( M, M, M))

    return newimage

##chuong trinh chinh
def main():

    ## tao link cho hinh can xu ly
    hinh = r'lena_color.png'
	
    ## doc anh dung thu vien dung opencv
    img = cv2.imread(hinh, cv2.IMREAD_COLOR)

    ##doc hinh dung thu vien PIL thay vi dung opencv
    imgPIL = Image.open(hinh)

    ##doc ve gia tri anh muc xam
    Grascale = RGBtoGrayscale(imgPIL, 0) 

    ##doc ve anh da phan doan mau
    NEWImage = NhanDangDuongBien(Grascale, "S", 130)

    ##chuyen ve anh thuong
    Grascale = np.array(Grascale)
    NEWImage = np.array(NEWImage)
    
    ## hien thi hinh
    cv2.imshow('Hinh goc co gai lena', img)
    cv2.imshow('Hinh muc xam co gai lena', Grascale)
    cv2.imshow('Nhan dang duong bien co gai lena', NEWImage)

	## thoat hinh bang cach nhan phim bat ki
    cv2.waitKey(0)

    ## xoa data
    cv2.destroyAllWindows()
      
if __name__ == "__main__" :
    main()