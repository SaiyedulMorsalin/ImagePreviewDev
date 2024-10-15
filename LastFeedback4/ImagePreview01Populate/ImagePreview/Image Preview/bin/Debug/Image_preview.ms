


try(dotnet.loadassembly  (getFilenamePath  (getThisScriptFilename())+@"\Image Preview.dll") )catch() 	
----------------------------------
	
rollout imageloader "small browser" width:240 height:270
(	
	dotNetControl small_dialog "Image_Preview.UserControl1"  pos:[0,0] width:480 height:480
	dotNetControl mybtn "Image_Preview.Controls.mybtn"
	

	
	
	
	
	on imageloader open do
   (

	  
	   --showEvents  small_dialog
	
	small_dialog.Filepath=@"C:\MyAssets\Model library\bed\bed cover pillow\"
	small_dialog.Reload()
	small_dialog.Select()	   
	   
   )
   
   edittext extentions "Extentions:" text:".jpg|.png|"
     button b04 "Root"
   on b04 pressed do 
   (

	   small_dialog.Filepath=@"C:\MyAssets\Model library\bed\bed cover pillow\"
	   small_dialog.Reload()
   )
   button b01 "Refresh"
   on b01 pressed do 
   (
	print "Reload"
    f = getFiles "C:\\Users\\mdsai\\OneDrive\\Desktop\\*.jpg"
    print f.count  
    print "load path"
    fileArray = #() 
    for i in f do
    (
        print i  
        append fileArray i  
    )
	showMethods small_dialog
    
	   small_dialog.Populate "" fileArray
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
	button b03 "Copy To Root Directory"
	   on b03 pressed do
	   (
		small_dialog.Extensions = extentions.text
		mypath = thePath = getSavepath()
		small_dialog.Filepath=@"C:\MyAssets\Model library\bed\bed cover pillow\"
		small_dialog.DirectoryLoad mypath
		small_dialog.Reload()
		print mypath
		print "Copy to Base Directory "
		   
	   )
    button b05 "Clear All Image Cache"
   on b05 pressed do 
   (

	   small_dialog.Reload()
	   
   )
   
)



imagedialog = newRolloutFloater "small browser" 500 650
addRollout  imageloader imagedialog


