## khai bao thu vien
## thu vien opencv
import cv2
## thu vien numpy dung de tinh toan
import numpy as np
## thu vien pillow ho tro
from PIL import Image

## khai bao bien
threshold = 128

## tao link cho hinh can xu ly
hinh = r'lenna.jpg'

## doc anh dung thu vien dung opencv
img = cv2.imread(hinh, cv2.IMREAD_COLOR)

## doc anh dung thu vien PIL thay vi dung opencv
imgPIL = Image.open(hinh)

## lay kich thuoc anh
width = imgPIL.size[0]
height = imgPIL.size[1]

##khai bao 3 bien chua anh GrayLightness GrayAverage GrayLuminance co cung mode va kich thuc
PictureBinaryPIL = Image.new(imgPIL.mode, imgPIL.size)

## quet hinh tu trai sang phai tu tren xuong duoi 
for x in range (width): 
	for y in range(height):
		## tach mau red green blue
		R, G, B = imgPIL.getpixel((x, y))

		## tinh toan gtr binary
		binary = np.uint8((R*0.2126 + G*0.7152 + B*0.0722))
		
        ##so sanh gtri binary  voi gtri threshold
		if binary <= threshold:
			binary = 0
		else:
			binary = 255

		##gan gtri diem anh vao anh
		PictureBinaryPIL.putpixel((x,y),(binary, binary, binary))

##chuyen anh tu PIL sang opencv de hien thi
PictureBinary = np.array(PictureBinaryPIL)

## hien thi hinh
cv2.imshow('Hinh Goc RGB co gai Lena', img)
cv2.imshow('Hinh Gray dung pp Lightness', PictureBinary)

## thoat hinh ban cach nhan phim bat ki
cv2.waitKey(0)

## xoa data
cv2.destroyAllWindows()