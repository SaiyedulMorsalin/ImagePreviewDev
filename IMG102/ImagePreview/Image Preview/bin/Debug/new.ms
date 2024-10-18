try(dotnet.loadassembly  (getFilenamePath  (getThisScriptFilename())+@"\Image Preview.dll"))catch()
---------------------------------------------------

rollout imageloader "Image Browser" width:500 height:500
(	
    -- Adding the custom .NET control from Image Preview.dll
	dotNetControl small_dialog "Image_Preview.UserControl1" pos:[10,10] width:480 height:480

    -- Edit text field for defining file extensions (default: .jpg, .png)
    edittext extentions "Extensions:" text:".jpg|.png" pos:[10, 500] width:200

    -- Button to refresh and reload the image list
    button b01 "Refresh" pos:[220,500] width:100

    -- Button to select a directory
    button b02 "Select Directory" pos:[340,500] width:150
    
    -- Event handler for the "Refresh" button press
    on b01 pressed do 
    (
        local fileArray = #()  -- Initialize empty array for file paths
        append fileArray @"C:\Users\mdsai\OneDrive\Desktop\pro_struc.png"  -- Example image
        print "Reloading Image Preview"
		showMethods small_dialog
        
        -- Populate the .NET control with the file array
        small_dialog.Populate "" fileArray
        showEvents small_dialog
    )
    
    -- Event handler for the "Select Directory" button press
    on b02 pressed do
    (
        small_dialog.extensions = extentions.text  -- Set file extensions in .NET control
        local selectedPath = getSavePath()  -- Open file dialog to select directory
        
        if selectedPath != undefined do
        (
            local fileArray = getFiles (selectedPath + "\\" + extentions.text)  -- Get all files with the selected extensions
            small_dialog.Populate selectedPath fileArray  -- Populate .NET control with the selected files
            print ("Selected Directory: " + selectedPath)
        )
    )
    
    -- Event handler for when a thumbnail is clicked in the .NET control
    on small_dialog ThumbnailClicked do (
		
		print "Hello World"
		
		)
)

-- Create a floating window to display the rollout UI
imagedialog = newRolloutFloater "Image Browser" 520 550
addRollout imageloader imagedialog
