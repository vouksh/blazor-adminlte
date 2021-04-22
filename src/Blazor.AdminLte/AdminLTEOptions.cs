using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace Blazor.AdminLte
{
	public class AdminLTEOptions
	{

		private readonly IServiceProvider serviceProvider;
		private readonly Action<AdminLTEOptions> configureOptions;

		public AdminLTEOptions(IServiceProvider serviceProvider, Action<AdminLTEOptions> configureOptions)
		{
			this.serviceProvider = serviceProvider;
			this.configureOptions = configureOptions;

			this.configureOptions?.Invoke(this);
		}

		/// <summary>
		/// If true, enables dark-mode site-wide. 
		/// </summary>
		public bool DarkModeEnabled { get; set; }

		public IServiceProvider Services => serviceProvider;
	}
}
