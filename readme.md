This reproduces a problem I am having with yFiles.YWorks for .net.  I want this code to be able to run in a windows server.

I want to use .net6.0 TFM, not .net6.0-windows.

You will have to manually copy the yFiles.NET 5.4 dlls to the lib folder.

When you run you will get this error:

~~~stacktrace
System.IO.FileNotFoundException: 'Could not load file or assembly 'System.Windows.Forms, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'. The system cannot find the file specified.'
~~~

I am trying to get it to work witout WinForms.  I want to use the graphing logic without using the winforms components of the graph.  Is this possible?
