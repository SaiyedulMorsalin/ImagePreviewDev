


try(dotnet.loadassembly  (getFilenamePath  (getThisScriptFilename())+@"\Image Preview.dll") )catch() 	
----------------------------------
	
rollout imageloader "small browser" width:240 height:270
(	
	dotNetControl small_dialog "Image_Preview.UserControl1"  pos:[0,0] width:480 height:480
	dotNetControl mybtn "Image_Preview.Controls.mybtn"
	

	
	
	
	
	on imageloader open do
   (

	  
	   --showEvents  small_dialog
	
	--small_dialog.Filepath=@"C:\MyAssets\Model library\bed\bed cover pillow\"
	--small_dialog.Reload()
	--small_dialog.Select()	   
	   
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

   )
   
   
   button b02 "Select directory"
   on b02 pressed do
   (
	   small_dialog.extensions = extentions.text
	   mypath = thePath = getSavepath()
		filearray = #()
	   small_dialog.Populate mypath filearray
	   print "Select Directory...!"
	   print mypath
		
   )
	
   
)



imagedialog = newRolloutFloater "small browser" 500 650
addRollout  imageloader imagedialog


