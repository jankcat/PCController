using Solid.Arduino;
using Solid.Arduino.Firmata;

namespace PCController.Library
{
    public class DigitalOutputPin : Pin, IOutputPin
    {
        public DigitalOutputPin(int pinNumber, ArduinoSession session) : base(pinNumber, session)
        {
            if (IsCorrectPinType()) return;
            _s.SetDigitalPinMode(_pinNumber, PinMode.DigitalOutput);
        }

        public bool GetValue()
        {
            if (!IsCorrectPinType()) return false;
            var state = _s.GetPinState(_pinNumber);
            if (state.Value != 0) return true;
            return false;
        }

        public long GetRawValue()
        {
            if (!IsCorrectPinType()) return 0;
            var state = _s.GetPinState(_pinNumber);
            return state.Value;
        }

        public override bool IsCorrectPinType()
        {
            var state = _s.GetPinState(_pinNumber);
            if (state.Mode == PinMode.DigitalOutput) return true;
            return false;
        }

        public void SetValue(object val)
        {
            if (val.GetType() != typeof(bool)) return;
            if (!IsCorrectPinType()) return;
            _s.SetDigitalPin(_pinNumber, (bool)val);
        }
    }
}
