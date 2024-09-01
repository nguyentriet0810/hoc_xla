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

##trong bai nay chon vung mau co toa do (80,400); (150;500)
def TinhVectorTrungBinhMau(RGBimage):

    ##tinh kich thuoc vung mau
    Size = (500-400)*(150-80)

    Rs = np.uint32(0)
    Gs = np.uint32(0)
    Bs = np.uint32(0)

    ##quet anh tu trai sang phai 
    for x in range (80, 151):
         
         ##quet anh tu tren xuong duoi 
         for y in range (400, 501):

            ##lay cac diem anh co trong cong thuc
            R, G, B = RGBimage.getpixel((x, y))

            ##tinh toan gia tri cac kenh mau theo cong thuc
            Rs = Rs + R
            Gs = Gs + G
            Bs = Bs + B

    ##tinh vector trung binh mau
    a = ((Rs/Size), 
         (Gs/Size), 
         (Bs/Size))
    
    ##tra ve gia tri cua vector
    return a

##ham phan doan anh mau
##chon gia tri nguong la 45
def PhanDoanAnhMau(RGBimage, vector):

    ##lay kich thuoc anh
    width = RGBimage.size[0]
    height = RGBimage.size[1]

    ##tao bien chua hinh anh cung mode va kich thuc
    newimage = Image.new(RGBimage.mode, RGBimage.size)

    ##quet anh tu trai sang phai 
    for x in range (width):
         
         ##quet anh tu tren xuong duoi 
         for y in range (height):
             
            ##lay diem anh
            R, G, B = RGBimage.getpixel((x, y))

            ##tinh toan cac gia tri kenh mau
            DR = np.float16((R - vector[0]) * (R - vector[0]))
            DG = np.float16((G - vector[1]) * (G - vector[1]))
            DB = np.float16((B - vector[2]) * (B - vector[2]))

            ##tinh toan gia tri Eu-clidean distance
            D = np.float16(math.sqrt(DR + DG + DB))

            ##so sanh voi gia tri nguong
            ##neu be hon gia tri nguong la background va set gia tri 3 kenh la 255
            ##neu lon hon gia tri nguong la object thi giu nguyen gia tri cac kenh mau
            if D <= 45: 

                R = np.uint8(255)
                G = np.uint8(255)
                B = np.uint8(255)
            
            ##set gia tri cho diem anh
            newimage.putpixel((x,y),(B, G, R)) 

    #tra ve gia tri cua anh
    return newimage

##chuong trinh chinh
def main():

    ## tao link cho hinh can xu ly
    hinh = r'lena_color.png'
	
    ## doc anh dung thu vien dung opencv
    img = cv2.imread(hinh, cv2.IMREAD_COLOR)

    ##doc hinh dung thu vien PIL thay vi dung opencv
    imgPIL = Image.open(hinh)

    ##tinh va tra ve gia tri cua vector trung binh mau
    a = TinhVectorTrungBinhMau(imgPIL) 

    ##lay anh ve va doi sang anh thuong
    NEWImage = PhanDoanAnhMau(imgPIL, a)
    NEWImage = np.array(NEWImage)
    
    ## hien thi hinh
    cv2.imshow('Phan doan anh mau co gai lena', NEWImage)

	## thoat hinh bang cach nhan phim bat ki
    cv2.waitKey(0)

    ## xoa data
    cv2.destroyAllWindows()
      
if __name__ == "__main__" :
    main()