// Models/ErrorViewModel.cs
namespace CLASS_MANAGER.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string ErrorMessage { get; set; }

        public string ErrorTitle { get; set; }
    }
}
