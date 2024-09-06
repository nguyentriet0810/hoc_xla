##programmed by nhom 1 xla thu 2 tiet 4-6 
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
## thu vien ve do thi
import matplotlib.pyplot as plt

def RGBtoCMYK(image):
    ##lay kich thuoc anh
    width = image.size[0]
    height = image.size[1]
    
    ##tao tuple gom 4 phan tu chua anh Cyan, Magenta, Yellow, Black co cung mode va kich thuoc voi anh goc
    CMYK = (Image.new(image.mode, image.size),
            Image.new(image.mode, image.size), 
            Image.new(image.mode, image.size),
            Image.new(image.mode, image.size))

    ##quet anh tu tu trai sang phai tu tren xuong duoi 
    for x in range (width):
         for y in range (height):
              
            ##tach mau R G B
            R, G, B = image.getpixel((x,y))

            ## so sanh va lay gia tri min R G B
            K = min(R, G, B)

            ##gan gia tri diem anh vao anh
            CMYK[0].putpixel((x, y), (B, G, 0))
            CMYK[1].putpixel((x, y), (B, 0, R))
            CMYK[2].putpixel((x, y), (0, G, R))
            CMYK[3].putpixel((x, y), (K, K, K))
    
    ##tra ve gia tri CMYK
    return CMYK

def main():
    ## tao link cho hinh can xu ly
    hinh = r'lena_color.png'
	
    ## doc anh dung thu vien dung opencv
    img = cv2.imread(hinh, cv2.IMREAD_COLOR)

    ##doc hinh dung thu vien PIL thay vi dung opencv
    imgPIL = Image.open(hinh)

    ## chuyen anh PIL ve anh thuong de hien thi
    Cyan = np.array(RGBtoCMYK(imgPIL)[0])
    Magenta = np.array(RGBtoCMYK(imgPIL)[1])
    Yellow = np.array(RGBtoCMYK(imgPIL)[2])
    Black = np.array(RGBtoCMYK(imgPIL)[3])

    ## hien thi hinh
    cv2.imshow('Hinh Goc RGB co gai lena', img)
    cv2.imshow('Hinh Cyan ', Cyan)
    cv2.imshow('Hinh Magenta', Magenta)
    cv2.imshow('Hinh Yellow', Yellow)
    cv2.imshow('Hinh Black', Black)

	## thoat hinh bang cach nhan phim bat ki
    cv2.waitKey(0)

    ## xoa data
    cv2.destroyAllWindows()
      
if __name__ == "__main__" :
    main()