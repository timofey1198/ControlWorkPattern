import zipfile
import os


print('Input variant number:')
variant = int(input())

print('Input folder name for archivation:')
folder = input()


z = zipfile.ZipFile('Starodubtsev_T.M._%i.zip'%variant, 'w')

for root, dirs, files in os.walk(folder):
   for file in files:
      z.write(os.path.join(root,file))

z.close()