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

##ham tinh toan anh muc xam
def RGBtoGrayscale(image, i):
	## lay kich thuoc anh
	width = image.size[0]
	height = image.size[1]
	##khai bao bien chua anh GrayLightness GrayAverage GrayLuminance co cung mode va kich thuc
	GrayLightnessPIL = Image.new(image.mode, image.size)
	GrayAveragePIL = Image.new(image.mode, image.size)
	GrayLuminancePIL = Image.new(image.mode, image.size)

	## quet hinh tu trai sang phai tu tren xuong duoi 
	for x in range (width): 
		for y in range (height):
			## tach mau red green blue
			R, G, B = image.getpixel((x, y))
			## so sanh 
			Max = max(R, G, B)
			Min = min(R, G, B)
			## tinh toan theo cong thuc
			Average = np.uint8((R+G+B)/3)
			Lightness = np.uint8((Max + Min)/2)
			Luminance = np.uint8(R*0.2126 + G*0.7152 + B*0.0722)
			##gan gtri diem anh vao anh
			GrayAveragePIL.putpixel((x,y),(Average, Average, Average))
			GrayLightnessPIL.putpixel((x,y),(Lightness, Lightness, Lightness))
			GrayLuminancePIL.putpixel((x,y),(Luminance, Luminance, Luminance))
	##chuyen anh tu PIL sang opencv de hien thi
	if i == 0:
		return GrayAveragePIL
	elif i == 1:
		return GrayLightnessPIL
	elif i == 2: 
		return GrayLuminancePIL

## ham tinh toan histogram cua anh muc xam
def tinhHistogramGrayscale(Grayscale):
	his = np.zeros(256)
	## lay kich thuoc anh
	width = Grayscale.size[0]
	height = Grayscale.size[1]
	## quet hinh tu trai sang phai tu tren xuong duoi 
	for x in range (width): 
		for y in range (height):
			## tach mau red green blue
			R, G, B = Grayscale.getpixel((x, y))

			##hinh xam 3 kenh giong nhau chi can lay 1 kenh
			his[R] += 1
	##tra ve gia tri histogram
	return his

def tinhHistogramRGB(RGBscale):
	his = (np.zeros(256),
			np.zeros(256),
			np.zeros(256))
	## lay kich thuoc anh
	width = RGBscale.size[0]
	height = RGBscale.size[1]
	## quet hinh tu trai sang phai tu tren xuong duoi 
	for x in range (width): 
		for y in range(height):
			## tach mau red green blue
			R, G, B = RGBscale.getpixel((x, y))

			##hinh xam 3 kenh giong nhau chi can lay 1 kenh
			his[0][R] += 1
			his[1][G] += 1
			his[2][B] += 1

	##tra ve gia tri histogram
	return his

##Ham ve bieu do histogram dung matplotlib
def BieudoHistogramGray(value):
	
	##tao kich thuoc
	w = 5
	h = 4
	plt.figure('Bieu do Histogram anh muc xam', figsize=(((w, h))), dpi = 100)

	X = np.zeros(256)
	X = np.linspace(0, 256, 256)
	plt.plot(X, value, color = 'orange')
	plt.title('Bieu do Histogram')
	plt.xlabel('Gia tri muc xam')
	plt.ylabel('So muc xam')
	plt.show()

##Ham ve bieu do histogram dung matplotlib
def BieudoHistogramRGB(value):
	w = 5
	h = 4
	plt.figure('Bieu do Histogram anh RGB', figsize=(((w, h))), dpi = 100)

	X = np.zeros(256)
	X = np.linspace(0, 256, 256)
	plt.plot(X, value[0], color = 'red')
	plt.plot(X, value[1], color = 'green')
	plt.plot(X, value[2], color = 'blue')
	plt.title('Bieu do Histogram')
	plt.xlabel('Gia tri R G B')
	plt.ylabel('So muc cung gia tri')
	plt.show()

##chuong trinh chinh
def main():
	## tao link cho hinh can xu ly
	hinh = r'bird_small.jpg'
	## doc anh dung thu vien dung opencv
	img = cv2.imread(hinh, cv2.IMREAD_COLOR)
	## doc anh dung thu vien PIL thay vi dung opencv
	imgPIL = Image.open(hinh)

	GrayAverage = np.array(RGBtoGrayscale(imgPIL, 0))
	##GrayLightness = np.array(RGBtoGrayscale(imgPIL, 1))
	##GrayLuminance = np.array(RGBtoGrayscale(imgPIL, 2))

	## hien thi hinh
	cv2.imshow('Hinh Goc RGB con chim nho', img)
	cv2.imshow('Hinh Gray dung pp Average', GrayAverage)
	##cv2.imshow('Hinh Gray dung pp Lightness',GrayLightness)
	##cv2.imshow('Hinh Gary dung pp Luminance', GrayLuminance)

	BieudoHistogramGray(tinhHistogramGrayscale(RGBtoGrayscale(imgPIL, 0)))

	BieudoHistogramRGB(tinhHistogramRGB(imgPIL))

	## thoat hinh bang cach nhan phim bat ki
	cv2.waitKey(0)

	## xoa data
	cv2.destroyAllWindows()

if __name__ == "__main__":
	main()
	