namespace FirstSteps
{
    public class Car
    {
        private string _model;
        private bool _engineStatus;

        public Car(string model)
        {
            _model = model;
        }

        public string GetModel()
        {
            return _model;
        }

        public void SetModel(string newModelValue)
        {
            _model = newModelValue;
        }

        public bool EngineStatus()
        {
            return _engineStatus;
        }

        public void RunEngine()
        {
            _engineStatus = true;
        }
    }
}