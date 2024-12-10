function ShowMessage(message)
{
	console.log(message);
}

const FormContainer = document.createElement("div");
FormContainer.className = "form-container";
const form = document.createElement("form");
form.id = "myForm";

for (let i = 1; i <= 5; i++)
{
	const input = document.createElement("input");
	input.type = "text";
	input.name = "field" + i;
	input.placeholder = "Mező " + i;
	
	input.addEventListener("input", function()
	{
		ShowMessage(`Mező $(i); $(this.value)`);
	});
	form.appendChild(input);
}
const button = document.createElement("button");
button.type = "submit";
button.textContent = "Elküld";
button.addEventListener("click", function()
{
	ShowMessage("Elküldve!");
});
form.addEventListener("submit", function(event)
{
	event.preventDefault();
	const formData = new FormData(form);
	const data = {};
	
	formData.forEach((value, key) =>
	{
	data[key] = value;
	});
	const JsonData = JSON.stringify(data);
	ShowMessage(`Form adatok: $(JsonData)`);
});
form.appendChild(button);
FormContainer.appendChild(form);
document.body.appendChild(FormContainer);