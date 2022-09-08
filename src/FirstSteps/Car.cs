namespace FirstSteps
{
    public class Car
    {
        private string _model;

        public Car(string model)
            
        {
            _model = model;
        }
        public string GetModel()
        {
            return _model;
        }
    }
}