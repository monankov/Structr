using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Structr.AspNetCore.JavaScript;
using System;
using System.Threading.Tasks;

namespace Structr.AspNetCore.Mvc
{
    /// <summary>
    /// Represents an alert to be send along with action result.
    /// </summary>
    public class JavaScriptAlertResult : IActionResult
    {
        private readonly IActionResult _result;
        private readonly JavaScriptAlert _alert;

        /// <summary>
        /// Creates an instance of <see cref="JavaScriptAlert"/>.
        /// </summary>
        /// <param name="result"><see cref="IActionResult"/> to attach alert to.</param>
        /// <param name="alert">Alert to attach to <see cref="IActionResult"/>.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public JavaScriptAlertResult(IActionResult result, JavaScriptAlert alert)
        {
            if (result == null)
            {
                throw new ArgumentNullException(nameof(result));
            }
            if (alert == null)
            {
                throw new ArgumentNullException(nameof(alert));
            }

            _result = result;
            _alert = alert;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            var alertProvider = context.HttpContext.RequestServices.GetRequiredService<IJavaScriptAlertProvider>();
            alertProvider.AddAlert(_alert);

            await _result.ExecuteResultAsync(context);
        }
    }
}
