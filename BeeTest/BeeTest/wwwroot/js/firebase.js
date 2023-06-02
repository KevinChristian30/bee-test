var firebaseConfig = {
    apiKey: "AIzaSyDBKtAWkt6yYOkbCFq3cQ2nkgqlFTh33DU",
    authDomain: "beetest-d2a84.firebaseapp.com",
    projectId: "beetest-d2a84",
    storageBucket: "beetest-d2a84.appspot.com",
    messagingSenderId: "154934210167",
    appId: "1:154934210167:web:5934ffb445bb0cef86a072",
    measurementId: "G-WJZR8N5TD3"
};

firebase.initializeApp(firebaseConfig);

window.uploadFileToFirebase = async function (folderName, fileName, file) {
    if (file == null) {
        alert('File must filled');
        return "";
    }

    var fileExtension = file.name.split('.').pop().toLowerCase();
    if (fileExtension !== 'zip') {
        alert('File must be a .zip file');
        return "";
    }

    var fileSizeMB = file.size / (1024 * 1024);
    if (fileSizeMB > 100) {
        alert('File size must be less than 100 MB');
        return "";
    }

    return new Promise((resolve, reject) => {
        var storageRef = firebase.storage().ref();

        var uploadTask = storageRef.child(folderName + '/' + fileName).put(file);

        uploadTask.on(firebase.storage.TaskEvent.STATE_CHANGED,
            function (snapshot) {
            },
            function (error) {
                resolve("");
            },
            function () {
                uploadTask.snapshot.ref.getDownloadURL().then(function (downloadURL) {
                    resolve(downloadURL);
                });
            }
        );
    });
};

window.clearFileInput = function (fileInput) {
    if (fileInput) {
        fileInput.value = '';
    }
};
