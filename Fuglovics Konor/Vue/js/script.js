Vue.component('props-demo', 
{
	props: ['message'],
	template:
	` <div>
		<h3>{{ message }}</h3>
		<p>({subtitle})</p>
	</div>`
});

// Szülő Vue instance
new Vue({
	el: '#app',
	data:
	{
		message: '',
		subtitle: '',
		additionalMessage: '';
	},
	methods:
	{
		changeMessage()
		{
			this.message = 'Ez az új üzenet gombnyomás után!';
		},
		changeMessage2()
		{
			this.message = 'Sziaaaa :3';
		},
		changeMessage3()
		{
			this.message = 'A Windows 7 a legjobb operációs rendszer!';
		},
		changeSubtitle()
		{
			this.message = 'Ez az új alcím gombnyomás után';
		},
		showAdditionalMessage()
		{
			this.message = 'This message will appear now!';
		}
	}
});