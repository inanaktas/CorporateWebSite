
function GetJSONDataFromForm(formId) {

	let formData = {};

	$.each($('#' + formId).serializeArray(), function () {

		formData[this.name] = this.value;

	});

	let data = JSON.stringify(formData);

	return data;
}



