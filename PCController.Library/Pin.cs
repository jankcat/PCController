using Solid.Arduino;

namespace PCController.Library
{
    public abstract class Pin : IPin
    {
        protected int _pinNumber;
        protected ArduinoSession _s;

        public Pin(int pinNumber, ArduinoSession session)
        {
            _pinNumber = pinNumber;
            _s = session;
        }

        public abstract bool IsCorrectPinType();
    }
}
