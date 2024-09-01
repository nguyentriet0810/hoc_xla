##programmed by nhom 1 lop xu ly anh thu 2 tiet 4-6 
##Nguyen Hoang Minh Triet - 21151176
##Phan Duy Kien - 21151122
##============================================================================

"""
==============================================================================
Ly thuyet chuyen mau RGB sang HSV
***
Tai sao lai chuyen he RGB sang he HSI?
RGB is standard primary colors. the RGB system matches nicely with the fact that the human eye is
strongly perceptive to red, green, and blue primaries.
CMYK is the secondary colors of light or, alternatively, the primary colors of pigments.
    Most devices that deposit colored pigments on paper, such as color printers
    and copiers, require CMY data input or perform an RGB to CMY conversion
    internally.
    In image processing this color model is used in connection with generating hardcopy output, 
    so the inverse operation from CMY to RGB generally is of little practical interest.
Unfortunately, the RGB, CMY, and other similar color models are not well suited for describing
    colors in terms that are practical for human interpretation. When humans view a color object, 
    we describe it by its hue, saturation, and brightness
HSI (hue, saturation, intensity) color model, decouples the intensity component from the color-carrying 
    information (hue and saturation) in a color image. As a result, the HSI model is an ideal tool 
    for developing image processing algorithms based on color descriptions that are natural and 
    intuitive to humans, who, after all, are the developers and users of these algorithms.
***
Recipe:
    V = max(R, G, B)
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
def RGBtoHSVusePillow(image):

    ##lay kich thuoc anh
    width = image.size[0]
    height = image.size[1]
    
    ##tao tuple gom 4 phan tu chua anh Cyan, Magenta, Yellow, Black co cung mode va kich thuoc voi anh goc
    HSV = (Image.new(image.mode, image.size),
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

            ##tinh toan theo cong thuc
            sum = R + G + B

            ## tinh toan kenh Hue
            t1 = ((R-G)+(R-B))/2
            t2 = math.sqrt((R-G)*(R-G) + (R-B)*(G-B))
            theta_r = math.acos(t1/t2) #ham nay tra ve gia tri radian [-1,1]
            t3 = 0
            if B <= G:
                t3 = theta_r
            elif B > G:
                t3 = 2*math.pi - theta_r 
            theta_d = math.degrees(t3) ##ham chuyen radian ve do
            h = np.uint16(theta_d) ##gtri do [0,360] nen dung bien 16 bit
            H = np.uint8(h) ##gioi han gia tri ve 8 bit neu ko se bi loi do kenh mau co gia tri 8 bit

            ##inh toan kenh saturation
            t4 = 1-3*K/sum
            S = np.uint8(t4*255)

            ##tinh toan kenh Intensity
            V = np.uint8(max(R, G, B))

            ##gan gia tri diem anh vao anh
            HSV[0].putpixel((x, y), (H, H, H))
            HSV[1].putpixel((x, y), (S, S, S))
            HSV[2].putpixel((x, y), (V, V, V))
            HSV[3].putpixel((x, y), (V, S, H))
    
    ##tra ve gia tri HSI
    return HSV

##chuong trinh chinh
def main():

    ## tao link cho hinh can xu ly
    hinh = r'lena_color.png'
	
    ## doc anh dung thu vien dung opencv
    img = cv2.imread(hinh, cv2.IMREAD_COLOR)

    ##doc hinh dung thu vien PIL thay vi dung opencv
    imgPIL = Image.open(hinh)

    ##lay anh ve
    imgHSV = RGBtoHSVusePillow(imgPIL)

    ## chuyen anh PIL ve anh thuong de hien thi
    Hue = np.array(imgHSV[0])
    Saturation = np.array(imgHSV[1])
    Value = np.array(imgHSV[2])
    HSVImage = np.array(imgHSV[3])

    ## hien thi hinh
    cv2.imshow('Hinh Goc RGB co gai lena', img)
    cv2.imshow('Kenh hinh Hue ', Hue)
    cv2.imshow('Kenh hinh Saturation', Saturation)
    cv2.imshow('Kenh hinh Value', Value)
    cv2.imshow('Hinh HSV', HSVImage)

	## thoat hinh bang cach nhan phim bat ki
    cv2.waitKey(0)

    ## xoa data
    cv2.destroyAllWindows()
      
if __name__ == "__main__" :
    main()