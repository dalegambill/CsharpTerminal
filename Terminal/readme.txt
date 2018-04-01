04/01/2018, Dale Gambill
------------------------
- Version 1.0.0.2
- In Serial_Rx_Tx.cs, corrected spelling of DataReceivedHandler (was DataReceviedHandler). This
  improved the readability of the code, but did not affect its operation.  (Thanks to Resonanz for
  pointing out this typo.)

- I added this comment: IMPORTANT: The dot net function below, comPort.ReadLine(), will not throw an
  error if there is no data, but might throw 'System.TimeoutException', if the data is not lines of
  text terminated by /n.  This would be because ReadLine() cannot find a line terminator in the wrong
  type of data. This code is intended for use with lines of text only.  It is not intended for use
  with any other type of data.

12/22/2017, Dale Gambill
------------------------
- Version 1.0.0.1
- Removed WriteTimeout() and ReadTimeout() functions.

12/19/2017, Dale Gambill
------------------------
- Version 1.0.0.0
I wrote this serial data program in C# so that I could compare it to the one I wrote in Python 3.5.
I wrote terminal.cs and serial_rs_tx.cs on Windows 10 in Visual Studio 2017.
