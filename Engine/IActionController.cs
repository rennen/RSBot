namespace Engine
{
    public interface IActionController
    {
        void StartProgress();
        void StopProgress(bool success);

        void ReportError(string message);
        void ReportWarning(string message);
    }

    public class ActionControllerEvents
    {
        public delegate void InvokeActionHandler(object sender, EventArgs<IActionController> args);
    }
}