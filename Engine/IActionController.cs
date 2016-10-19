using Engine;

namespace RSBot
{
    public interface IActionController
    {
        void Progress(int percetangeCopleted);
        void ReportError(string message);
    }

    public class ActionControllerEvents
    {
        public delegate void InvokeActionHandler(object sender, EventArgs<IActionController> args);
    }
}