global imageloader

try (dotnet.loadassembly (getFilenamePath (getThisScriptFilename()) + @"\Image Preview.dll")) catch()

rollout imageloader "Image Browser" width:700 height:700
(
    dotNetControl small_dialog "Image_Preview.UserControl1" pos:[0,0] width:700 height:500

    -- Event handler for ThumbnailClicked event
    

    -- EditText to specify file extensions
    edittext extensions "Extensions:" text:".jpg|.png|"
    
    -- Buttons
    button b01 "Refresh"

    button b04 "Show Selected Image"

    on b01 pressed do 
    (
        -- Load images from the file array when Refresh is pressed
        fileArray = #()
        append fileArray @"C:\Users\mdsai\OneDrive\Desktop\studio design.png"
        append fileArray @"C:\Users\mdsai\OneDrive\Desktop\sss.png"
        append fileArray @"C:\Users\mdsai\OneDrive\Desktop\studio design.png"

        -- Populate the control with images
        small_dialog.Populate "" fileArray
        print small_dialog.CurrentItem
        print small_dialog.name
    )

    on b04 pressed do 
    (
        -- Print details of the currently selected item
        print "Show selected image"
        print small_dialog.scriptCommand
        print small_dialog.CurrentItem
        print small_dialog.CurrentImage
    )
    button b02 "Select Directory"
    on b02 pressed do
    (
        -- Update the extensions and populate images from a directory
        small_dialog.extensions = extensions.text
        mypath = getSavepath()
        filearray = #()
        small_dialog.Populate mypath filearray
        print "Select Directory...!"
        print mypath
    )
)

CreateDialog imageloader
