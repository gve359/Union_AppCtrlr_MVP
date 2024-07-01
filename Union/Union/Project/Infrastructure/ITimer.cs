
using System;

namespace Project.Infrastructure
{
	public interface ITimer
	{
		event Action Started;		
		event Action Stopped;
		event Action Ticked;
			
		TimeSpan delay {get; set;}
		bool IsEnable {get;}
		void Start();
		void Stop();
	}	
}
