var count = 0;

const elem = document.createElement('div');
const pee = document.createElement('p');

document.body.appendChild(elem);
document.body.appendChild(pee);
const butt = document.getElementById('faf');

pee.textContent = count;

butt.addEventListener('click', function()
{
	count += 1;
	pee.textContent = count;
})
console.log(elem);
console.log(text1);