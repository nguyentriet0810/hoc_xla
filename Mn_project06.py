##programmed by nhom 1 lop xu ly anh thu 2 tiet 4-6 
##Nguyen Hoang Minh Triet - 21151176
##Phan Duy Kien - 21151122
##============================================================================

"""
==============================================================================
Ly thuyet chuyen mau RGB sang CMYK
***
Tai sao lai chuyen he RGB sang he CMYK?
RGB is standard primary colors
CMYK is the secondary colors of light or, alternatively, the primary colors of pigments.
Most devices that deposit colored pigments on paper, such as color printers
and copiers, require CMY data input or perform an RGB to CMY conversion
internally.
In image processing this color model is used in connection with generating hardcopy output, 
so the inverse operation from CMY to RGB generally is of little practical interest.
***
Recipe:
[C,M,Y]^T = [1,1,1]^T - [R,G,B]^T
K = min (R, G, B)
==============================================================================
"""

## khai bao thu vien
## thu vien opencv
import cv2
## thu vien numpy dung de tinh toan
import numpy as np
## thu vien pillow ho tro
from PIL import Image

"""
##ham chuyen doi khong gian mau RGB sang CMYK dung opencv
def RGBtoCMYKuseOpencv(image):
    ##lay kich thuoc anh
    width = len(image[0])
    height = len(image[1])
    
    ##tao tuple gom 4 phan tu chua anh Cyan, Magenta, Yellow, Black co cung mode va kich thuoc voi anh goc
    CMYK = (np.zeros((width, height, 3), np.uint8),
            np.zeros((width, height, 3), np.uint8), 
            np.zeros((width, height, 3), np.uint8),
            np.zeros((width, height, 3), np.uint8))

    ## cho cac thong so ban dau = 0
    CMYK[0][:] =[0, 0, 0]
    CMYK[1][:] =[0, 0, 0]
    CMYK[2][:] =[0, 0, 0]
    CMYK[3][:] =[0, 0, 0]

    ##quet anh tu tu trai sang phai tu tren xuong duoi 
    for x in range (width):
         for y in range (height):
              
            ##tach mau R G B
            R = image[x, y, 2]
            G = image[x, y, 1]
            B = image[x, y, 0]

            ## so sanh va lay gia tri min R G B
            K = min(R, G, B)

            ##gan gia tri diem anh vao anh
            ## anh Cyan
            CMYK[0][x, y, 0] = B
            CMYK[0][x, y, 1] = G

            ##anh Magenta
            CMYK[1][x, y, 2] = R
            CMYK[1][x, y, 0] = B

            #anh Yellow
            CMYK[2][x, y, 2] = R
            CMYK[2][x, y, 1] = G

            #anh Black
            CMYK[3][x, y, 2] = K
            CMYK[3][x, y, 1] = K
            CMYK[3][x, y, 0] = K
    
    ##tra ve gia tri CMYK
    return CMYK
"""

##ham chuyen doi khong gian mau RGB sang CMYK dung Pillow
def RGBtoCMYKusePillow(image):
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

##chuong trinh chinh
def main():
    ## tao link cho hinh can xu ly
    hinh = r'lena_color.png'
	
    ## doc anh dung thu vien dung opencv
    img = cv2.imread(hinh, cv2.IMREAD_COLOR)

    ##doc hinh dung thu vien PIL thay vi dung opencv
    imgPIL = Image.open(hinh)

    """
    ##lay anh ve
    CMYK = RGBtoCMYKuseOpencv(img)
    Cyan = CMYK[0]
    Magenta = CMYK[1]
    Yellow = CMYK[2]
    Black = CMYK[3]
    """
    
    #""""
    ## chuyen anh PIL ve anh thuong de hien thi
    CMYK = RGBtoCMYKusePillow(imgPIL)
    Cyan = np.array(CMYK[0])
    Magenta = np.array(CMYK[1])
    Yellow = np.array(CMYK[2])
    Black = np.array(CMYK[3])
    #"""

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