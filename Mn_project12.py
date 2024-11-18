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

##tao mat na
mask = [[0, -1, 0], 
        [-1, 4,-1], 
        [0, -1, 0]]

##lam sat net anh dung thu vien ho tro Pillow
def lamsatnetanh_mask(RGBimage):

    d = 0
    c = 0

    ##lay kich thuoc anh
    width = RGBimage.size[0]
    height = RGBimage.size[1]

    ##tao bien chua hinh anh cung mode va kich thuc
    newimage = Image.new(RGBimage.mode, RGBimage.size)

    ##quet anh tu trai sang phai 
    for a in range (1, width-1):
         
         ##quet anh tu tren xuong duoi 
         for b in range (1, height-1):
            
            R, G, B = RGBimage.getpixel((a, b))
            
            gR = np.int16(0)
            gG = np.int16(0)
            gB = np.int16(0)

            ##quet mawt na
            for x in range (a-1, a+2):
                for y in range (b-1, b+2):
                    
                    R, G, B = RGBimage.getpixel((x,y))

                    gR = gR + np.int16(R*mask[d][c])
                    gG = gG + np.int16(G*mask[d][c])
                    gB = gB + np.int16(B*mask[d][c])

                    d += 1
                    if d > 2: 
                        d = 0

                c += 1 
                if c > 2:
                    c = 0

            gR = gR + R
            gG = gG + G
            gB = gB + B

            ##gioi han lai gia tri diem anh [0,255]
            if gR < 0:
                gR = 0
            elif gR > 255:
                gR = 255
            if gG < 0:
                gG = 0
            elif gG > 255:
                gG = 255
            if gB < 0:
                gB = 0
            elif gB > 255:
                gB = 255

            ##doi kieu du lieu do gia tri mau la bien 8bit [0,255]
            gR = np.uint8(gR)
            gG = np.uint8(gG)
            gB = np.uint8(gB)

            ##set gia tri vao tung diem anh
            newimage.putpixel((a, b), (gB, gG, gR))
    
    ##tra ve gia tri cua anh
    return newimage

def lamsatnetanh_math(RGBimage):

    d = 0
    c = 0

    ##lay kich thuoc anh
    width = RGBimage.size[0]
    height = RGBimage.size[1]

    ##tao bien chua hinh anh cung mode va kich thuc
    newimage = Image.new(RGBimage.mode, RGBimage.size)

    ##quet anh tu trai sang phai 
    for a in range (1, width-1):
         
         ##quet anh tu tren xuong duoi 
         for b in range (1, height-1):
            
            ##lay cac diem anh co trong cong thuc
            R1, G1, B1 = RGBimage.getpixel((a, b))
            R2, G2, B2 = RGBimage.getpixel((a - 1, b))
            R3, G3, B3 = RGBimage.getpixel((a + 1, b))
            R4, G4, B4 = RGBimage.getpixel((a, b - 1))
            R5, G5, B5 = RGBimage.getpixel((a, b + 1))

            ##tinh toan gia tri cac kenh mau theo cong thuc
            gR = np.int16(R1 + (-1)*(R2 + R3 + R4 + R5 + (-4) * R1 ))
            gG = np.int16(G1 + (-1)*(G2 + G3 + G4 + G5 + (-4) * G1 ))
            gB = np.int16(B1 + (-1)*(B2 + B3 + B4 + B5 + (-4) * B1 ))

            ##gioi han lai gia tri diem anh [0,255]
            if gR < 0:
                gR = 0
            elif gR > 255:
                gR = 255
            if gG < 0:
                gG = 0
            elif gG > 255:
                gG = 255
            if gB < 0:
                gB = 0
            elif gB > 255:
                gB = 255

            ##doi kieu du lieu do gia tri mau la bien 8bit [0,255]
            gR = np.uint8(gR)
            gG = np.uint8(gG)
            gB = np.uint8(gB)

            ##set gia tri vao tung diem anh
            newimage.putpixel((a, b), (gB, gG, gR))
    
    ##tra ve gia tri cua anh
    return newimage
    
##chuong trinh chinh
def main():

    ## tao link cho hinh can xu ly
    hinh1 = r'lena_color.png'
    hinh2 = r'bird_small.jpg'

    ## doc anh dung thu vien dung opencv
    img1 = cv2.imread(hinh1, cv2.IMREAD_COLOR)
    img2 = cv2.imread(hinh2, cv2.IMREAD_COLOR)
    ##doc hinh dung thu vien PIL thay vi dung opencv
    imgPIL1 = Image.open(hinh1)
    imgPIL2 = Image.open(hinh2)

    ##lay anh ve va doi sang anh thuong
    newImage1 = lamsatnetanh_mask(imgPIL1) 
    newImage1 = np.array(newImage1)
    cv2.imshow('Hinh sau khi lam net Lena', newImage1)

    NewImage2 = lamsatnetanh_mask(imgPIL2) 
    NewImage2 = np.array(NewImage2)
    cv2.imshow('Hinh sau khi lam net bird small', NewImage2)
    ## hien thi hinh
    cv2.imshow('Hinh Goc RGB co gai Lena', img1)
    cv2.imshow('Hinh Goc RGB bird small', img2)    

	## thoat hinh bang cach nhan phim bat ki
    cv2.waitKey(0)

    ## xoa data
    cv2.destroyAllWindows()
      
if __name__ == "__main__" :
    main()