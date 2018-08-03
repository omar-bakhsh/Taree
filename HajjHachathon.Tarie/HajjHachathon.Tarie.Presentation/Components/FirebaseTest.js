  function writeCaseData(IMEI, Long, Lat, imageUrl) {
      firebase.database().ref('cases/' + IMEI).set({
          IMEI: IMEI,
          Long: Long,
          Lat: Lat,
          Path: imageUrl
      });
  }