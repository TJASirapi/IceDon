from PIL import Image
import glob
import os
 
lst_imgs = [i for i in glob.glob("*.png")]

print(lst_imgs)
for i in lst_imgs:
	img = Image.open(i)
	img = img.resize((int(img.width * 1.5), int(img.height * 1.5)), Image.ANTIALIAS)
	img.save(i[:-4] + ".png")
 
 
print("Done")