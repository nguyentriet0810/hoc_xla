##programmed by nhom 1 lop xu ly anh thu 2 tiet 4-6 
##Nguyen Hoang Minh Triet - 21151176
##Phan Duy Kien - 21151122
##============================================================================

"""
==============================================================================
Ly thuyet chuyen mau RGB sang XYZ
***
Ban chat he XYZ là 3 kenh muc xam của he RGB tinh theo cong thuc Grayscale Luminance
***
Recipe:
    X = apha1 * R + beta1 * G + gama1 * B
    Y = apha2 * R + beta2 * G + gama2 * B
    Z = apha3 * R + beta3 * G + gama3 * B
==============================================================================
"""

## khai bao thu vien
## thu vien opencv
import cv2
## thu vien numpy dung de tinh toan
import numpy as np
## thu vien pillow ho tro
from PIL import Image
##thu vien toan hoc trong python
import math

##ham chuyen doi khong gian mau RGB sang HSV dung Pillow
def RGBtoYCbCrusePillow(image):

    ##lay kich thuoc anh
    width = image.size[0]
    height = image.size[1]
    
    #
    YCbCr = (Image.new(image.mode, image.size),
            Image.new(image.mode, image.size), 
            Image.new(image.mode, image.size),
            Image.new(image.mode, image.size))

    ##quet anh tu tu trai sang phai tu tren xuong duoi 
    for a in range (width):
         for b in range (height):
              
            ##tach mau R G B
            R, G, B = image.getpixel((a, b))

            #tinh toan gia tri cac kenh x y z va chuyen ve gia tri 16 bit do kich thuoc bi tran
            Y = np.uint8( 16 + (65.738 * R + 159.057 * G + 25.064 * B) / 256)
            Cb = np.uint8(128 - (37.945 * R + 74.494 * G - 112.439 * B) / 256)
            Cr = np.uint8(128 + (112.439 * R - 94.154 * G - 18.285 * B) / 256)

            ##gan gia tri diem anh vao anh
            YCbCr[0].putpixel((a, b), (Y, Y, Y))
            YCbCr[1].putpixel((a, b), (Cb, Cb, Cb))
            YCbCr[2].putpixel((a, b), (Cr, Cr, Cr))
            YCbCr[3].putpixel((a, b), (Cr, Cb, Y))
    
    ##tra ve gia tri HSI
    return YCbCr

##chuong trinh chinh
def main():

    ## tao link cho hinh can xu ly
    hinh = r'lena_color.png'
	
    ## doc anh dung thu vien dung opencv
    img = cv2.imread(hinh, cv2.IMREAD_COLOR)

    ##doc hinh dung thu vien PIL thay vi dung opencv
    imgPIL = Image.open(hinh)

    ##lay anh ve
    imgYCbCr = RGBtoYCbCrusePillow(imgPIL)

    ## chuyen anh PIL ve anh thuong de hien thi
    Y = np.array(imgYCbCr[0])
    Cb = np.array(imgYCbCr[1])
    Cr = np.array(imgYCbCr[2])
    YCbCrImage = np.array(imgYCbCr[3])

    ## hien thi hinh
    cv2.imshow('Hinh Goc RGB co gai Lena', img)
    cv2.imshow('Kenh hinh Y ', Y)
    cv2.imshow('Kenh hinh Cb', Cb)
    cv2.imshow('Kenh hinh Cr', Cr)
    cv2.imshow('Hinh YCbCr', YCbCrImage)

	## thoat hinh bang cach nhan phim bat ki
    cv2.waitKey(0)

    ## xoa data
    cv2.destroyAllWindows()
      
if __name__ == "__main__" :
    main()