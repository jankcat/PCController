using Solid.Arduino;

namespace PCController.Library
{
    public class ArduinoOne
    {
        private ArduinoSession _s;

        public ArduinoOne() : this(SerialConnection.FindSerialConnection()) { }
        public ArduinoOne(ISerialConnection connection) : this(new ArduinoSession(connection)) { }
        public ArduinoOne(ArduinoSession session)
        {
            _s = session;
            PCCaseLEDs = new DigitalOutputPin(6, _s);
            MonitorLEDs = new DigitalOutputPin(7, _s);

        }

        public DigitalOutputPin PCCaseLEDs;
        public DigitalOutputPin MonitorLEDs;
    }
}
