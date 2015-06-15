
    function getExerciseID() {
        if ($("#programID").val() != "") {

            var url = '/PlannedRepsAndSets/Create/' + $("#programID").val();
            $(location).attr('href', url);
        }
    };
