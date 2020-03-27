const https = require('https');

let html = "";
let tulostettu = false;

https.get('https://www.ilmatieteenlaitos.fi/saa/turku', (res) => {
  //console.log('statusCode:', res.statusCode);
  //console.log('headers:', res.headers);

  res.on('data', (d) => {
    html = html + d;

    let indeksi = html.indexOf('<tr class="meteogram-temperatures">');
    // console.log(indeksi);
    if (indeksi > 0) {

      if (!tulostettu) {
        // console.log("Aloitus");
        let lämpötila = html.substr(indeksi + 118, 1);
        console.log("Lämpötila Turussa: "+ lämpötila + " astetta.");

        tulostettu = true;
      }
    }
  });

}).on('error', (e) => {
  console.error(e);
});
