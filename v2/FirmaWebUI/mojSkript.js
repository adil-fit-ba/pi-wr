var baseUrl = "https://firma.wrd.app.fit.ba";

function AlertPoruke(poruka)
{
	var now = new Date(Date.now());
	var formatted = now.getHours() + ":" + now.getMinutes() + ":" + now.getSeconds();
	var x =  "<div class='alert alert-primary' role='alert'> " + formatted + ": " + poruka+ "</div>";

	$("#alert-div").append(x);
	
	$(".alert").delay(5000).slideUp(200, function() {
    $(this).alert('close');
});
}

function BtnUpdate(firmaID)
{
	var url = baseUrl +"/Firma/Dodaj";
	
	
}

function BtnDodaj()
{
	var url = baseUrl +"/Firma/Dodaj";
	
	
}

function BtnSnimi()
{
	var url = baseUrl +"/Firma/Dodaj";
	
	
}


function BtnObrisi(firmaID)
{
	var url = baseUrl +"/Firma/Obrisi";
	
	  $.post(url, function(data, status){
        alert("Obrisano: " + data + "\nStatus: " + status);
    });
}

function BtnPrikazi(){
	
	var url = baseUrl +"/Firma/Prikazi";

	AlertPoruke("Podaci se učitavaju sa servera...");
	
	$.getJSON(url , function(data) {
		AlertPoruke("Podaci su preuzeti sa servera...");
		var tbl_body = "";

		var i =0;
		$.each(data, function() {
			
			var tbl_row = "";
			
			$.each(this, function(k , v) {
				tbl_row += "<td>"+v+"</td>";
			});

			var firmaid = data[i].ID;
			
			tbl_row+= "<td>";
			
			tbl_row+= "<button onclick='BtnUpdate(" + firmaid + ")' class='btn btn-success'>Update</button>";
			tbl_row+= "<button onclick='BtnObrisi(" + firmaid + ")' class='btn btn-danger'>Obrisi</button>";
			tbl_row+= "</td>";
			
			tbl_body += "<tr>" + tbl_row + "</tr>";
			i++;
				   
		});
		$("#tabelabody").html(tbl_body);
	});
		
}

	
	
$( document ).ready(function() {
    console.log( "ready!" );
	
	AlertPoruke("Aplikacija je učitana. Upute za grešku <i>No 'Access-Control-Allow-Origin' header is present...</i> možete naći na <a href='https://stackoverflow.com/questions/20035101/why-does-my-javascript-get-a-no-access-control-allow-origin-header-is-present'>stackoverflow</a>");
	
});



