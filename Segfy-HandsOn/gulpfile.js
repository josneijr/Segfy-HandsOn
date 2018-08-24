/// <binding />
"use strict";

var _ = require('lodash'),
    gulp = require('gulp');

gulp.task('copy-assets', function() {
    var assets = {
        js: [
            './node_modules/@material-ui/core/Button/Button.js'
        ],
        css: ['./node_modules/bootstrap/dist/css/bootstrap.css']
    };
    _(assets).forEach(function(assets, type) {
        gulp.src(assets).pipe(gulp.dest('./wwwroot/' + type));
    });
});