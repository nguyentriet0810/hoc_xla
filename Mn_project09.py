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

##ham chuyen doi khong gian mau RGB sang HSV dung Pillow
def RGBtoXYZusePillow(image):

    ##lay kich thuoc anh
    width = image.size[0]
    height = image.size[1]
    
    ##tao tuple gom 4 phan tu chua anh Cyan, Magenta, Yellow, Black co cung mode va kich thuoc voi anh goc
    XYZ = (Image.new(image.mode, image.size),
            Image.new(image.mode, image.size), 
            Image.new(image.mode, image.size),
            Image.new(image.mode, image.size))

    ##quet anh tu tu trai sang phai tu tren xuong duoi 
    for a in range (width):
         for b in range (height):
              
            ##tach mau R G B
            R, G, B = image.getpixel((a, b))

            #tinh toan gia tri cac kenh x y z va chuyen ve gia tri 8bit
            x = np.uint8(0.4124564 * R + 0.3575761 * G + 0.1804375 * B)
            y = np.uint8(0.2126729 * R + 0.7151522 * G + 0.0721750 * B)
            z = np.uint8(0.0193339 * R + 0.1191920 * G + 0.9503041 * B)

            ##gan gia tri diem anh vao anh
            XYZ[0].putpixel((a, b), (x, x, x))
            XYZ[1].putpixel((a, b), (y, y, y))
            XYZ[2].putpixel((a, b), (z, z, z))
            XYZ[3].putpixel((a, b), (z, y, x))
    
    ##tra ve gia tri HSI
    return XYZ

##chuong trinh chinh
def main():

    ## tao link cho hinh can xu ly
    hinh = r'lena_color.png'
	
    ## doc anh dung thu vien dung opencv
    img = cv2.imread(hinh, cv2.IMREAD_COLOR)

    ##doc hinh dung thu vien PIL thay vi dung opencv
    imgPIL = Image.open(hinh)

    ##lay anh ve
    imgXYZ = RGBtoXYZusePillow(imgPIL)

    ## chuyen anh PIL ve anh thuong de hien thi
    X = np.array(imgXYZ[0])
    Y = np.array(imgXYZ[1])
    Z = np.array(imgXYZ[2])
    XYZImage = np.array(imgXYZ[3])

    ## hien thi hinh
    cv2.imshow('Hinh Goc RGB co gai Lena', img)
    cv2.imshow('Kenh hinh X ', X)
    cv2.imshow('Kenh hinh Y', Y)
    cv2.imshow('Kenh hinh Z', Z)
    cv2.imshow('Hinh XYZ', XYZImage)

	## thoat hinh bang cach nhan phim bat ki
    cv2.waitKey(0)

    ## xoa data
    cv2.destroyAllWindows()
      
if __name__ == "__main__" :
    main()