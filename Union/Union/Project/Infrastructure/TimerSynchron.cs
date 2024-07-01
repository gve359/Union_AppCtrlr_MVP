
using System;
using System.Threading.Tasks;

namespace Project.Infrastructure
{
	public class TimerSynchron : ITimer  
	{
		/// <summary>
		/// Таймер такой, как выглядел бы Threas.Sleep в RepeatUntil, если бы полностью не блокировал поток.
		///	Если в методе класса, подписанном на событие Ticked этого таймера, исполнение потока в заблокируется, то новых запусков Ticked не будет, пока поток не разблокируется.
		/// </summary>
		
		public event Action Started = delegate{};
		public event Action Stopped = delegate{};
		public event Action Ticked = delegate{};
		
		public TimeSpan delay {get; set;}
		public bool IsEnable {get; private set; }		
		
		public TimerSynchron()
		{
			this.IsEnable = false;
			this.delay = new TimeSpan(0,0,1);
		}
		
		public void Start()
		{
			if (this.IsEnable == false)
			{
				this.IsEnable = true;
				this.Started();
				this.RunCycle();
			}
		}
		
		public void Stop()
		{
			if (this.IsEnable)
			{
				this.IsEnable = false;
				this.Stopped();	// то, что на самом деле цикл ещё продолжется какое-то время не имеет значения, ведь работать будет задержка, а Tick() уже не сработает.
			}
		}
		
		private async void RunCycle()
		{
			while(this.IsEnable)
			{
				this.Ticked();
				await Task.Delay(this.delay);
			}
		}
	}
}





 




