Vue.component('greeting-component',
{
	props: ['message'],
	template: '<h1>{{ message }}</h1>'
});

new Vue({
	el: '#app',
	data:
	{
		name: '',
		age: '',
		hobbies: ['Programozás', 'Játék szerkesztés', 'Muzsikálás', 'Sportolás', 'Adatlopás (pls do no report)'],
		greetingMessage: 'Adat vizsgáló program :3',
	},
	computed:
	{
		ageStatus()
		{
			if (this.age >= 60)
			{
				return 'Nyugger';
			}
			else if (this.age >= 18)
			{
				return 'Felnőtt';
			}
			else if (this.age >= 1)
			{
				return 'Kiskorú';
			}
			else if (this.age == 0)
			{
				return 'Magzat';
			}
			else if (this.age < 0)
			{
				return 'Nem létező életkor!'
			}
			else
			{
				return '';
			}
		}
	},
	methods:
	{
		changeMessage()
		{
			this.greetingMessage = 'Adat lopó program >:3';
		}
	}
});