var baseUrl = "https://firma.wrd.app.fit.ba";

function UpdateForma(firmaID)
{
	var url = baseUrl +"/Firma/Dodaj";
	
	
}

function UpdateAkcija()
{
	var url = baseUrl +"/Firma/Dodaj";
	
	
}


function ObrisiAkcija(firmaID)
{
	var url = baseUrl +"/Firma/Obrisi";
	
	  $.post(url, function(data, status){
        alert("Obrisano: " + data + "\nStatus: " + status);
    });
}

function PrikaziForma(){
	
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
				
				tbl_row+= "<td> <button onclick='UpdateForma(" + firmaid + ")'>Update</button> </td>";
				tbl_row+= "<td> <button onclick='ObrisiAkcija(" + firmaid + ")'>Obrisi</button> </td>";
				
				tbl_body += "<tr>" + tbl_row + "</tr>";
				i++;
			           
			});
			$("#tabelabody").html(tbl_body);
		});
		
	}
	



