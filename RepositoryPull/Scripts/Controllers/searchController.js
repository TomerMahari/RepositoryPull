var app = angular.module("githubApp", []);

app.controller("searchController", function ($scope, $http) {

    $scope.repName = "";
    $scope.repositories = {};
    $scope.bookMarks = {};
    $scope.showBookmarks = false;


    $scope.getRepositories = function () {
        $http.get("/api/git/getrepositories/" + $scope.repName)
            .then(function (res) {
                $scope.repositories = res.data;
            })
    }

    $scope.addBookmark = function (rep) {
        $http.post("/api/git/addbookmark", rep)
            .then(function (res) {
                if (res.data == true)
                    alert("Bookmark added successfully");
                else
                    alert("Bookmark was not added");
            })
    }
    $scope.getBookmarks = function () {
        $http.post("/api/git/getbookmarks")
            .then(function (res) {
                $scope.bookMarks = res.data;
                $scope.showBookmarks = true;
            })
    }
    $scope.backBtn = function () {
        $scope.showBookmarks = false;
    }
})