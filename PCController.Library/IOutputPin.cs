namespace PCController.Library
{
    interface IOutputPin : IPin
    {
        bool GetValue();
        void SetValue(object val);
    }
}
