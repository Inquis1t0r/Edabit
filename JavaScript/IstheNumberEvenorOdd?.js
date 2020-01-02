var mmod = function (n, m) {
    var remain = n % m;
    return Math.floor(remain >= 0 ? remain : remain + m);
};

function isEvenOrOdd(num) {
	return mmod(num,2) == 0 ? "even" : "odd";
}

