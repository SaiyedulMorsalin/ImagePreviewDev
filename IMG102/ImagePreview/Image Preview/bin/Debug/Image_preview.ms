


try(dotnet.loadassembly  (getFilenamePath  (getThisScriptFilename())+@"\Image Preview.dll") )catch() 	
----------------------------------
	
rollout imageloader "small browser" width:240 height:270
(	
	dotNetControl small_dialog "Image_Preview.UserControl1"  pos:[0,0] width:480 height:480
	

	
	
	
	
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
	   
	   
	 directoryPath = @"C:\Users\mdsai\OneDrive\Pictures\Screenshots"


fileArray = getFiles (directoryPath + "\\*.png")
		
	   small_dialog.Populate fileArray
	   
	   

   )
 
   button b02 "Select directory"
   on b02 pressed do
   (
	   small_dialog.extensions = extentions.text
	   mypath = thePath = getSavepath()
	   filearray = #()
	   small_dialog.Populate mypath 
	   print mypath
		
   )
	
	on small_dialog ThumbPicked sender args do(
		
		
		print "Thumb Click From Event"
		print small_dialog.CurrentItem
		
		)
   
)



imagedialog = newRolloutFloater "small browser" 500 650
addRollout  imageloader imagedialog


