# WinFormServer
A bidirectional C# Windows Forms server application that can send and receive commands from connected clients

The WinFormServer demonstrates fundamental concepts in Client-Server application programming. Key concepts include:
- How to create a multi-homed, multi-threaded server application
- How to access GUI components from separate threads without crashing the program. The key piece of code to study here is the Utils/ISynchronizeInvokeExtensions.cs file.
-- Example: To write to the _statusTextBox located on the main GUI window running on the main thread from another thread you would do this:
             _statusTextBox.InvokeEx(stb => stb.Text += CRLF + "Problem communicating with the server.");
     
 ...in this example, CRLF is a string constant defined as "\r\n"
 
- How to coordinate Client-Server communications in a bi-directional flow. 

This application is meant to be used in conjunction with the WinFormClient application which is located in a separate repository.

- The implemented behavior is a simple echo client-server application. Additional behavior can be implemented by adding appropriate cases to the switch statement located in the ProcessClientRequests() method. 
- The server broadcasts commands to all connected clients. 

Notes: Error handling is not robustly implemented, but sufficiently so. Server disconnects from all clients when shutdown via the Stop Server button. (This should happen as well on FormClosing event, but is not yet implemented.)
