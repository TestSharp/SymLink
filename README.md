# SymLink

This program helps you with the MKLINK command in Windows by adding a GUI to the process.
Because it calls for the command prompt, you need admin priviledges to be able to run it.

You cannot create a hard link from a network share. You must use a symbolic link instead.

Warning: If you incorrectly specify the destination path, such as having the destination and source paths backwards, it will delete the file/folder you are presumably trying to create a symlink from.

You will be presented with a confirmation prompt that shows you which folder will be replaced/deleted.

This is a modified GUI for the open source project: https://sourceforge.net/projects/symlink-creator/files/Symlink%20Creator%201.3/
