try (
    dotnet.loadassembly (getFilenamePath (getThisScriptFilename()) + @"\Image Preview.dll")
) catch ()

rollout imageloader "small browser" width:240 height:270
(
    -- Load the custom user control from the C# assembly
    dotNetControl small_dialog "Image_Preview.UserControl1" pos:[0, 0] width:550 height:480
    dotNetControl searchBox "System.Windows.Forms.TextBox" width:100 height:20 pos:[10, 490]


 
    on searchBox KeyUp s e do
    (
		local searchTextMx = searchBox.Text
		
		
		
		print ("Key data: " + searchTextMx)
		small_dialog.SearchLoad(searchTextMx)
		
    )

    button b01 "Refresh" pos:[10, 520]
    on b01 pressed do
    (
        -- Specify the directory path and load images into the dialog
        directoryPath = @"C:\Users\mdsai\OneDrive\Desktop\"
        fileArray = getFiles (directoryPath + "*.jpg")
        small_dialog.Populate fileArray
    )

    button b02 "Select Directory" pos:[100, 520]
    on b02 pressed do
    (
        mypath = getSavepath()
        if mypath != undefined do
        (
            fileArray = getFiles (mypath + "*.jpg")
            small_dialog.Populate fileArray
            print mypath
        )
    )

    -- Event handler for when a thumbnail is clicked in the custom control
    on small_dialog.ThumbPicked sender args do
    (
        print "Thumb Click From Event"
        print small_dialog.CurrentItem
    )
)

imagedialog = newRolloutFloater "small browser" 600 650
addRollout imageloader imagedialog
