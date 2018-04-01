// 
// Serial COM Port receive message event handler
// 12/16/2017, Dale Gambill
// When a line of text arrives from the COM port terminated by a \n character, this module will pass the message to
// the function specified by the application.   The application can also send a line of text.
//
// IMPORTANT: The dot net function below, comPort.ReadLine(), will not throw an error if there is no data, but might throw 'System.TimeoutException', if the data
// is not lines of text terminated by /n.  This would be because ReadLine() cannot find a line terminator in the wrong type of data.
// This code is intended for use with lines of text only.  It is not intended for use with any other type of data.
//
using System;
using System.IO.Ports;
using System.Diagnostics;

namespace SERIAL_RX_TX
{
  public class SerialComPort
  {
    private SerialPort comPort;
    
    // constructor
    public SerialComPort()
    {
      comPort = new SerialPort();
  }

    ~SerialComPort()
    {
      Close();
    }


    // User must register function to call when a line of text terminated by \n has been received
    public delegate void ReceiveCallback(string receivedMessage);
    public event ReceiveCallback onMessageReceived = null;
    public void RegisterReceiveCallback(ReceiveCallback FunctionToCall)
    {
      onMessageReceived += FunctionToCall;
    }
    public void DeRegisterReceiveCallback(ReceiveCallback FunctionToCall)
    {
      onMessageReceived -= FunctionToCall;
    }

    public void SendLine(string aString)
    {
      try
      {
        if (comPort.IsOpen)
        {
          comPort.Write(aString);
        }
      }
      catch (Exception exp)
      {
        Debug.Print(exp.Message);
      }
    }

    public string Open(string portName, string baudRate, string dataBits, string parity, string stopBits)
    {
      try
      {
        comPort.WriteBufferSize = 4096;
        comPort.ReadBufferSize = 4096;
        comPort.WriteTimeout = 500;
        comPort.ReadTimeout = 500;
        comPort.DtrEnable = true;
        comPort.Handshake = Handshake.None;
        comPort.PortName = portName.TrimEnd();
        comPort.BaudRate = Convert.ToInt32(baudRate);
        comPort.DataBits = Convert.ToInt32(dataBits);
        switch (parity)
        {
          case "None":
            comPort.Parity = Parity.None;
            break;
          case "Even":
            comPort.Parity = Parity.Even;
            break;
          case "Odd":
            comPort.Parity = Parity.Odd;
            break;
        }
        switch (stopBits)
        {
          case "One":
            comPort.StopBits = StopBits.One;
            break;
          case "Two":
            comPort.StopBits = StopBits.Two;
            break;
        }
        comPort.Open();
        comPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
      }
      catch (Exception error)
      {
        return error.Message + "\r\n";
      }
      if (comPort.IsOpen)
      {
        return string.Format("{0} Opened \r\n", comPort.PortName);
      }
      else
      {
        return string.Format("{0} Open Failed \r\n", comPort.PortName);
      }
    }

    public string Close()
    {
      try
      {
        comPort.Close();
      }
      catch (Exception error)
      {
        return error.Message + "\r\n";
      }
      return string.Format("{0} Closed\r\n", comPort.PortName);
    }

    public bool IsOpen()
    {
      return comPort.IsOpen;
    }

    private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
    {
      if (!comPort.IsOpen)
      {
        return;
      }
      string indata = string.Empty;
      try
      {
        indata = comPort.ReadLine();
        indata += "\n";
        if (onMessageReceived != null)
        {
          onMessageReceived(indata);
        }
      }
      catch (Exception error)
      {
        Debug.Print(error.Message);
      }
       
    }
  }
}
