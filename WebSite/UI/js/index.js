var app = angular.module('myApp', ['ngStorage', 'ui.bootstrap', 'angularFileUpload'])
var ctrl = app.controller('myCtrl', function ($scope, $http, $localStorage, $uibModal, $filter, fileReader, $rootScope) {

    $scope.getLocations = function () {
        $http.get("/api/Location/getLocations").then(function (response, req) {
            $scope.Location = response.data;

        });
    }
    $scope.GetLocationImages = function (locid) {

        // $http.get("/api/image/GetDocsList").then(function (response, req) {
        $http.get("/api/image/GetLocationImages?locid="+$scope.loc.id).then(function (response, req) {
            $scope.parentImgs = response.data;
        });

    }
    $scope.Getlist6 = function () {

        $http.get("/api/child/GetDocsList").then(function (response, req) {
            //$http.get("/api/child/Getalldocs").then(function (response, req) {
            $scope.list6 = response.data;
        });

    }

    $scope.getImagePreview = function (imgid) {
       
        for (var i = 0; i < $scope.parentImgs.length; i++)
        {
            if ($scope.parentImgs[i].Id == imgid) {
                document.getElementById('imgPreview').src = $scope.parentImgs[i].FileContent;
                break;
            }
        }
    }

    $scope.GetChildImgPreview = function (event) {

        var x = event.x;
        var y = event.y;
        var offsetX = event.offsetX;
        var offsetY = event.offsetY;
        if (navigator.userAgent.indexOf("Firefox") != -1) {
             offsetX = event.originalEvent.layerX;
             offsetY = event.originalEvent.layerY;
        }
        else {
             offsetX = event.offsetX;
             offsetY = event.offsetY;
        }       

        $http.get("/api/child/GetChildImagePreview?x=" + offsetX + "&y=" + offsetY).then(function (response, req) {          
            $scope.ChildImageDetails = response.data;
            openPDF($scope.ChildImageDetails[0].imageContent, $scope.ChildImageDetails[0].imageName);
        });
    }

    function openPDF(resData, fileName) {

        var blob = null;
        var ext = fileName.split('.').pop();
        if (ext == 'csv') {
            blob = new Blob([resData], { type: "text/csv" });
            saveAs(blob, fileName);
        }
        else {

            var ieEDGE = navigator.userAgent.match(/Edge/g);
            var ie = navigator.userAgent.match(/.NET/g); // IE 11+
            var oldIE = navigator.userAgent.match(/MSIE/g);

            if (ie || oldIE || ieEDGE) {
                blob = b64toBlob(resData, (ext == 'csv') ? 'text/csv' : 'application/pdf');
                // window.open(blob, '_blank');
                //  window.navigator.msSaveBlob(blob, fileName);
                saveAs(blob, fileName);
                //openReportWindow('test', resData, 1000, 700);
                //window.open(resData, '_blank');
                //  var a = document.createElement("a");
                //  document.body.appendChild(a);
                //  a.style = "display: none";
                //  a.href = resData;
                //  a.download = fileName;
                ////  a.onclick = "window.open(" + fileURL + ", 'mywin','left=200,top=20,width=1000,height=800,toolbar=1,resizable=0')";
                //  a.click(); 

            }
            else {

                openReportWindow(fileName, resData, 600, 400);
                // newWindow =   window.open(resData, 'newwin', 'left=200,top=20,width=1000,height=700,toolbar=1,resizable=0');
                //   timerObj = window.setInterval("ResetTitle('"+fileName+"')", 10);
            }
        }
    }


    function b64toBlob(b64Data, contentType) {
        contentType = contentType || '';
        var sliceSize = 512;
        b64Data = b64Data.replace(/^[^,]+,/, '');
        b64Data = b64Data.replace(/\s/g, '');
        var byteCharacters = window.atob(b64Data);
        var byteArrays = [];

        for (var offset = 0; offset < byteCharacters.length; offset += sliceSize) {
            var slice = byteCharacters.slice(offset, offset + sliceSize);

            var byteNumbers = new Array(slice.length);
            for (var i = 0; i < slice.length; i++) {
                byteNumbers[i] = slice.charCodeAt(i);
            }

            var byteArray = new Uint8Array(byteNumbers);

            byteArrays.push(byteArray);
        }

        var blob = new Blob(byteArrays, { type: contentType });
        return blob;
    }


    var winLookup;
    var showToolbar = false;

    function openReportWindow(m_title, m_url, m_width, m_height) {
        var strURL;
        var intLeft, intTop;

        strURL = m_url;

        // Check if we've got an open window.
        if ((winLookup) && (!winLookup.closed))
            winLookup.close();

        // Set up the window so that it's centered.
        intLeft = (screen.width) ? ((screen.width - m_width) / 2) : 0;
        intTop = 20;//(screen.height) ? ((screen.height - m_height) / 2) : 0;

        // Open the window.
        winLookup = window.open('', 'winLookup', 'scrollbars=no,resizable=yes,toolbar=' + (showToolbar ? 'yes' : 'no') + ',height=' + m_height + ',width=' + m_width + ',top=' + intTop + ',left=' + intLeft);
        checkPopup(m_url, m_title);

        // Set the window opener.
        if ((document.window != null) && (!winLookup.opener))
            winLookup.opener = document.window;

        // Set the focus.
        if (winLookup.focus)
            winLookup.focus();
    }

    function checkPopup(m_url, m_title) {
        if (winLookup.document) {
            var ext = m_title.split('.').pop();
            switch (ext) {
                case 'pdf':
                    winLookup.document.write('<html><head><title>' + m_title + '</title></head><body height="100%" width="100%"><object  data="' + m_url + '" height="100%" width="100%" ></object></body></html>');
                    break;
                case 'csv':

                    var blob = new Blob([resData], 'text/csv');
                    saveAs(blob, m_title);

                    break;
                default:
                    winLookup.document.write('<html><head><title>' + m_title + '</title></head><body height="100%" width="100%"><img src="' + m_url + '" height="100%" width="100%" /></body></html>');
                    break;
            }
            // winLookup.document.write('<html><head><title>' + m_title + '</title></head><body height="100%" width="100%"><embed src="' + m_url + '" type="application/pdf" height="100%" width="100%" /></body></html>');
        } else {
            // if not loaded yet
            setTimeout(checkPopup(m_url, m_title), 10); // check in another 10ms
        }
    }
});
