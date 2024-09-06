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

##lam muot anh msak 3x3 dung Pillow
def ColorImageSmoothingMask3x3(image):

    ##lay kich thuoc anh
    width = image.size[0]
    height = image.size[1]

    ##tao bien luu anh co cung mode va kich thuoc
    SmoothedImage = Image.new(image.mode, image.size)

    ##quet anh tu tu trai sang phai tu tren xuong duoi 
    for a in range (1, width-1):
         for b in range (1, height-1):

            ##tao bien tinh tong
            Rs = np.uint8(0) 
            Gs = np.uint8(0)
            Bs = np.uint8(0)

            ##quet mat na
            for i in range (a - 1, a + 2):
                for j in range (b - 1, b + 2):
                    R, G, B = image.getpixel((i, j))

                    ##tinh tong
                    Rs = np.uint16(Rs + R)
                    Gs = np.uint16(Gs + G)
                    Bs = np.uint16(Bs + B)

            ##tinh gia tri trung binh
            Rs = np.uint8(Rs / 9)
            Gs = np.uint8(Gs / 9)
            Bs = np.uint8(Bs / 9)

            ##gan gia tri vao diem anh
            SmoothedImage.putpixel((a,b), (Bs, Gs, Rs))

    ##tra ve gia tri HSI
    return SmoothedImage

##lam muot anh msak 5x5 dung Pillow
def ColorImageSmoothingMask5x5(image):

    ##lay kich thuoc anh
    width = image.size[0]
    height = image.size[1]

    ##tao bien luu anh co cung mode va kich thuoc
    SmoothedImage = Image.new(image.mode, image.size)

    ##quet anh tu tu trai sang phai tu tren xuong duoi 
    for a in range (2, width-2):
         for b in range (2, height-2):

            ##tao bien tinh tong
            Rs = np.uint8(0) 
            Gs = np.uint8(0)
            Bs = np.uint8(0)

            ##quet mat na
            for i in range (a - 2, a + 3):
                for j in range (b - 2, b + 3):
                    R, G, B = image.getpixel((i, j))

                    ##tinh tong
                    Rs = np.uint16(Rs + R)
                    Gs = np.uint16(Gs + G)
                    Bs = np.uint16(Bs + B)

            ##tinh gia tri trung binh
            Rs = np.uint8(Rs / 25)
            Gs = np.uint8(Gs / 25)
            Bs = np.uint8(Bs / 25)

            ##gan gia tri vao diem anh
            SmoothedImage.putpixel((a,b), (Bs, Gs, Rs))

    ##tra ve gia tri HSI
    return SmoothedImage

##lam muot anh msak 7x7 dung Pillow
def ColorImageSmoothingMask7x7(image):

    ##lay kich thuoc anh
    width = image.size[0]
    height = image.size[1]

    ##tao bien luu anh co cung mode va kich thuoc
    SmoothedImage = Image.new(image.mode, image.size)

    ##quet anh tu tu trai sang phai tu tren xuong duoi 
    for a in range (3, width-3):
         for b in range (3, height-3):

            ##tao bien tinh tong
            Rs = np.uint8(0) 
            Gs = np.uint8(0)
            Bs = np.uint8(0)

            ##quet mat na
            for i in range (a - 3, a + 4):
                for j in range (b - 3, b + 4):
                    R, G, B = image.getpixel((i, j))

                    ##tinh tong
                    Rs = np.uint16(Rs + R)
                    Gs = np.uint16(Gs + G)
                    Bs = np.uint16(Bs + B)

            ##tinh gia tri trung binh
            Rs = np.uint8(Rs / 49)
            Gs = np.uint8(Gs / 49)
            Bs = np.uint8(Bs / 49)

            ##gan gia tri vao diem anh
            SmoothedImage.putpixel((a,b), (Bs, Gs, Rs))

    ##tra ve gia tri anh
    return SmoothedImage

##lam muot anh msak 9x9 dung Pillow
def ColorImageSmoothingMask9x9(image):

    ##lay kich thuoc anh
    width = image.size[0]
    height = image.size[1]

    ##tao bien luu anh co cung mode va kich thuoc
    SmoothedImage = Image.new(image.mode, image.size)

    ##quet anh tu tu trai sang phai tu tren xuong duoi 
    for a in range (4, width - 4):
         for b in range (4, height - 4):

            ##tao bien tinh tong
            Rs = np.uint8(0) 
            Gs = np.uint8(0)
            Bs = np.uint8(0)

            ##quet mat na
            for i in range (a - 4, a + 5):
                for j in range (b - 4, b + 5):
                    R, G, B = image.getpixel((i, j))

                    ##tinh tong
                    Rs = np.uint16(Rs + R)
                    Gs = np.uint16(Gs + G)
                    Bs = np.uint16(Bs + B)

            ##tinh gia tri trung binh
            Rs = np.uint8(Rs / 81)
            Gs = np.uint8(Gs / 81)
            Bs = np.uint8(Bs / 81)

            ##gan gia tri vao diem anh
            SmoothedImage.putpixel((a,b), (Bs, Gs, Rs))

    ##tra ve gia tri HSI
    return SmoothedImage

##chuong trinh chinh
def main():

    ## tao link cho hinh can xu ly
    hinh = r'lena_color.png'
	
    ## doc anh dung thu vien dung opencv
    img = cv2.imread(hinh, cv2.IMREAD_COLOR)

    ##doc hinh dung thu vien PIL thay vi dung opencv
    imgPIL = Image.open(hinh)

    ##lay anh ve va doi sang anh thuong
    """
    mask3x3 = ColorImageSmoothingMask3x3(imgPIL)
    mask3x3 = np.array(mask3x3)
    mask5x5 = ColorImageSmoothingMask5x5(imgPIL)
    mask5x5 = np.array(mask5x5)
    mask7x7 = ColorImageSmoothingMask7x7(imgPIL)
    mask7x7 = np.array(mask7x7)
    """
    mask9x9 = ColorImageSmoothingMask9x9(imgPIL)
    mask9x9 = np.array(mask9x9)

    ## hien thi hinh
    cv2.imshow('Hinh Goc RGB co gai Lena', img)
    """
    cv2.imshow('Hinh lam muot mask 3x3', mask3x3)
    cv2.imshow('Hinh lam muot mask 5x5', mask5x5)
    cv2.imshow('Hinh lam muot mask 7x7', mask7x7)
    """
    cv2.imshow('Hinh lam muot mask 9x9', mask9x9)

	## thoat hinh bang cach nhan phim bat ki
    cv2.waitKey(0)

    ## xoa data
    cv2.destroyAllWindows()
      
if __name__ == "__main__" :
    main()