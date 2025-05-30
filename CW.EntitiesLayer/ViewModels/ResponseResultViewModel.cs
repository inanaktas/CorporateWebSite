namespace CW.EntitiesLayer.ViewModels
{
	public class ResponseResultViewModel<T>
	{

		public T Result { get; set; }
		public bool IsSuccess { get; set; }
		public string Message { get; set; }
		public string ErrorMessage { get; set; }
	}
}
