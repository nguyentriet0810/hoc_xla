##programmed by nhom 1 xla thu 2 tiet 4-6 
##Nguyen Hoang Minh Triet - 21151176
##Phan Duy Kien - 21151122
##===============================================

## khai bao thu vien
## thu vien opencv
import cv2
## thu vien numpy dung de tinh toan
import numpy as np
## thu vien pillow ho tro
from PIL import Image

## tao link cho hinh can xu ly
hinh = r'lena_color.png'

## doc anh dung thu vien dung opencv
img = cv2.imread(hinh, cv2.IMREAD_COLOR)

## doc anh dung thu vien PIL thay vi dung opencv
imgPIL = Image.open(hinh)

## lay kich thuoc anh
width = imgPIL.size[0]
height = imgPIL.size[1]

##khai bao 3 bien chua anh GrayLightness GrayAverage GrayLuminance co cung mode va kich thuc
GrayLightnessPIL = Image.new(imgPIL.mode, imgPIL.size)
GrayAveragePIL = Image.new(imgPIL.mode, imgPIL.size)
GrayLuminancePIL = Image.new(imgPIL.mode, imgPIL.size)

## quet hinh tu trai sang phai tu tren xuong duoi 
for x in range (width): 
	for y in range(height):
		## tach mau red green blue
		R, G, B = imgPIL.getpixel((x, y))
       	## so sanh 
		Max = max(R, G, B)
		Min = min(R, G, B)
		## tinh toan theo cong thuc
		Average = np.uint8((R+G+B)/3)
		Lightness = np.uint8((Max + Min)/2)
		Luminance = np.uint8((R*0.2126 + G*0.7152 + B*0.0722))

		##gan gtri diem anh vao anh
		GrayAveragePIL.putpixel((x,y),(Average, Average, Average))
		GrayLightnessPIL.putpixel((x,y),(Lightness, Lightness, Lightness))
		GrayLuminancePIL.putpixel((x,y),(Luminance, Luminance, Luminance))

##chuyen anh tu PIL sang opencv de hien thi
GrayAverage = np.array(GrayAveragePIL)
GrayLightness = np.array(GrayLightnessPIL)
GrayLuminance = np.array(GrayLuminancePIL)

## hien thi hinh
cv2.imshow('Hinh Goc RGB co gai Lena', img)
cv2.imshow('Hinh Gray dung pp Lightness', GrayLightness)
cv2.imshow('Hinh Gray dung pp Average', GrayAverage)
cv2.imshow('Hinh Gary dung pp Luminance', GrayLuminance)

## thoat hinh bang cach nhan phim bat ki
cv2.waitKey(0)

## xoa data
cv2.destroyAllWindows()