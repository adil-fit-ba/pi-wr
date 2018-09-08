var baseUrl = "https://firma.wrd.app.fit.ba";

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

		$.getJSON(url , function(data) {
			var tbl_body = "";

			var i =0;
			$.each(data, function() {
				
				var tbl_row = "";
				
				$.each(this, function(k , v) {
					tbl_row += "<td>"+v+"</td>";
				});

				var firmaid = data[i].ID;
				
				tbl_row+= "<td>";
				
				tbl_row+= "<button onclick='UpdateForma(" + firmaid + ")'>Update</button>";
				tbl_row+= "<button onclick='ObrisiAkcija(" + firmaid + ")'>Obrisi</button>";
				tbl_row+= "</td>";
				
				tbl_body += "<tr>" + tbl_row + "</tr>";
				i++;
			           
			});
			$("#tabelabody").html(tbl_body);
		});
		
	}
	



