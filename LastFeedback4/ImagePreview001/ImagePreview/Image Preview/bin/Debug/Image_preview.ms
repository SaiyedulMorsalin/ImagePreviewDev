


try(dotnet.loadassembly  (getFilenamePath  (getThisScriptFilename())+@"\Image Preview.dll") )catch() 	
----------------------------------
	
rollout imageloader "small browser" width:240 height:270
(	
	dotNetControl small_dialog "Image_Preview.UserControl1"  pos:[0,0] width:480 height:480
	dotNetControl mybtn "Image_Preview.Controls.mybtn"
	

	
	
	
	
	on imageloader open do
   (

	  
	  
print mybtn.CurrentItem	   
	   
   )
   
   edittext extentions "Extentions:" text:".jpg|.png|"
   
   button b01 "Refresh"
   on b01 pressed do 
   (
		fileArray = #()
	   fileArry2= #()
	   append fileArray @"C:\Users\mdsai\OneDrive\Desktop\pro_struc.png"
	   print "Reload"
	   small_dialog.Populate "" fileArray
	   print @"C:\Users\mdsai\OneDrive\Pictures\Rate\"
		print mybtn.CurrentItem
	   print mybtn.Current
	   

   )
   button b03 "Current Item"
   on b03 pressed do 
   (
	
	   print mybtn.Current
	   

   )
   
   button b02 "Select directory"
   on b02 pressed do
   (
	   small_dialog.extensions = extentions.text
	   mypath = thePath = getSavepath()
	   small_dialog.Filepath=mypath
		small_dialog.Reload()
	   print "Select Directory...!"
	   print mypath
		
   )
   
)



imagedialog = newRolloutFloater "small browser" 500 650
addRollout  imageloader imagedialog


