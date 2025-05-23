﻿// Knockout JavaScript library v2.3.0
// (c) Steven Sanderson - http://knockoutjs.com/
// License: MIT (http://www.opensource.org/licenses/mit-license.php)

(function () {
    function F(q) { return function () { return q } }; (function (q) {
        var w = this || (0, eval)("this"), s = w.document, H = w.navigator, t = w.jQuery, y = w.JSON; (function (q) { "function" === typeof require && "object" === typeof exports && "object" === typeof module ? q(module.exports || exports) : "function" === typeof define && define.amd ? define(["exports"], q) : q(w.ko = {}) })(function (C) {
            function G(b, c, d, f) {
            a.d[b] = {
                init: function (b) { a.a.f.set(b, I, {}); return { controlsDescendantBindings: !0 } }, update: function (b, e, m, h, k) {
                    m = a.a.f.get(b, I); e = a.a.c(e()); h = !d !== !e; var l = !m.fb; if (l || c || h !== m.vb) l && (m.fb =
                        a.a.Oa(a.e.childNodes(b), !0)), h ? (l || a.e.P(b, a.a.Oa(m.fb)), a.Ja(f ? f(k, e) : k, b)) : a.e.ba(b), m.vb = h
                }
            }; a.g.S[b] = !1; a.e.L[b] = !0
            } function J(b, c, d) { d && c !== a.h.n(b) && a.h.W(b, c); c !== a.h.n(b) && a.q.I(a.a.Ga, null, [b, "change"]) } var a = "undefined" !== typeof C ? C : {}; a.b = function (b, c) { for (var d = b.split("."), f = a, g = 0; g < d.length - 1; g++)f = f[d[g]]; f[d[d.length - 1]] = c }; a.r = function (a, c, d) { a[c] = d }; a.version = "2.3.0"; a.b("version", a.version); a.a = function () {
                function b(a, b) { for (var e in a) a.hasOwnProperty(e) && b(e, a[e]) } function c(b,
                    e) { if ("input" !== a.a.u(b) || !b.type || "click" != e.toLowerCase()) return !1; var k = b.type; return "checkbox" == k || "radio" == k } var d = {}, f = {}; d[H && /Firefox\/2/i.test(H.userAgent) ? "KeyboardEvent" : "UIEvents"] = ["keyup", "keydown", "keypress"]; d.MouseEvents = "click dblclick mousedown mouseup mousemove mouseover mouseout mouseenter mouseleave".split(" "); b(d, function (a, b) { if (b.length) for (var e = 0, c = b.length; e < c; e++)f[b[e]] = a }); var g = { propertychange: !0 }, e = s && function () {
                        for (var a = 3, b = s.createElement("div"), e = b.getElementsByTagName("i"); b.innerHTML =
                            "\x3c!--[if gt IE " + ++a + "]><i></i><![endif]--\x3e", e[0];); return 4 < a ? a : q
                    }(); return {
                        Ta: ["authenticity_token", /^__RequestVerificationToken(_.*)?$/], p: function (a, b) { for (var e = 0, c = a.length; e < c; e++)b(a[e]) }, k: function (a, b) { if ("function" == typeof Array.prototype.indexOf) return Array.prototype.indexOf.call(a, b); for (var e = 0, c = a.length; e < c; e++)if (a[e] === b) return e; return -1 }, La: function (a, b, e) { for (var c = 0, d = a.length; c < d; c++)if (b.call(e, a[c])) return a[c]; return null }, ka: function (b, e) {
                            var c = a.a.k(b, e); 0 <= c &&
                                b.splice(c, 1)
                        }, Ma: function (b) { b = b || []; for (var e = [], c = 0, d = b.length; c < d; c++)0 > a.a.k(e, b[c]) && e.push(b[c]); return e }, Z: function (a, b) { a = a || []; for (var e = [], c = 0, d = a.length; c < d; c++)e.push(b(a[c])); return e }, Y: function (a, b) { a = a || []; for (var e = [], c = 0, d = a.length; c < d; c++)b(a[c]) && e.push(a[c]); return e }, R: function (a, b) { if (b instanceof Array) a.push.apply(a, b); else for (var e = 0, c = b.length; e < c; e++)a.push(b[e]); return a }, ja: function (b, e, c) { var d = b.indexOf ? b.indexOf(e) : a.a.k(b, e); 0 > d ? c && b.push(e) : c || b.splice(d, 1) },
                        extend: function (a, b) { if (b) for (var e in b) b.hasOwnProperty(e) && (a[e] = b[e]); return a }, w: b, oa: function (b) { for (; b.firstChild;)a.removeNode(b.firstChild) }, Mb: function (b) { b = a.a.N(b); for (var e = s.createElement("div"), c = 0, d = b.length; c < d; c++)e.appendChild(a.H(b[c])); return e }, Oa: function (b, e) { for (var c = 0, d = b.length, g = []; c < d; c++) { var f = b[c].cloneNode(!0); g.push(e ? a.H(f) : f) } return g }, P: function (b, e) { a.a.oa(b); if (e) for (var c = 0, d = e.length; c < d; c++)b.appendChild(e[c]) }, eb: function (b, e) {
                            var c = b.nodeType ? [b] : b; if (0 <
                                c.length) { for (var d = c[0], g = d.parentNode, f = 0, r = e.length; f < r; f++)g.insertBefore(e[f], d); f = 0; for (r = c.length; f < r; f++)a.removeNode(c[f]) }
                        }, hb: function (a, b) { 7 > e ? a.setAttribute("selected", b) : a.selected = b }, F: function (a) { return null === a || a === q ? "" : a.trim ? a.trim() : a.toString().replace(/^[\s\xa0]+|[\s\xa0]+$/g, "") }, Wb: function (b, e) { for (var c = [], d = (b || "").split(e), g = 0, f = d.length; g < f; g++) { var r = a.a.F(d[g]); "" !== r && c.push(r) } return c }, Tb: function (a, b) {
                            a = a || ""; return b.length > a.length ? !1 : a.substring(0, b.length) ===
                                b
                        }, yb: function (a, b) { if (b.compareDocumentPosition) return 16 == (b.compareDocumentPosition(a) & 16); for (; null != a;) { if (a == b) return !0; a = a.parentNode } return !1 }, aa: function (b) { return a.a.yb(b, b.ownerDocument) }, pb: function (b) { return !!a.a.La(b, a.a.aa) }, u: function (a) { return a && a.tagName && a.tagName.toLowerCase() }, o: function (b, d, k) {
                            var f = e && g[d]; if (f || "undefined" == typeof t) if (f || "function" != typeof b.addEventListener) if ("undefined" != typeof b.attachEvent) {
                                var n = function (a) { k.call(b, a) }, p = "on" + d; b.attachEvent(p, n);
                                a.a.C.ia(b, function () { b.detachEvent(p, n) })
                            } else throw Error("Browser doesn't support addEventListener or attachEvent"); else b.addEventListener(d, k, !1); else { if (c(b, d)) { var r = k; k = function (a, b) { var e = this.checked; b && (this.checked = !0 !== b.sb); r.call(this, a); this.checked = e } } t(b).bind(d, k) }
                        }, Ga: function (a, b) {
                            if (!a || !a.nodeType) throw Error("element must be a DOM node when calling triggerEvent"); if ("undefined" != typeof t) { var e = []; c(a, b) && e.push({ sb: a.checked }); t(a).trigger(b, e) } else if ("function" == typeof s.createEvent) if ("function" ==
                                typeof a.dispatchEvent) e = s.createEvent(f[b] || "HTMLEvents"), e.initEvent(b, !0, !0, w, 0, 0, 0, 0, 0, !1, !1, !1, !1, 0, a), a.dispatchEvent(e); else throw Error("The supplied element doesn't support dispatchEvent"); else if ("undefined" != typeof a.fireEvent) c(a, b) && (a.checked = !0 !== a.checked), a.fireEvent("on" + b); else throw Error("Browser doesn't support triggering events");
                        }, c: function (b) { return a.T(b) ? b() : b }, ya: function (b) { return a.T(b) ? b.t() : b }, ga: function (b, e, c) {
                            if (e) {
                                var d = /\S+/g, g = b.className.match(d) || []; a.a.p(e.match(d),
                                    function (b) { a.a.ja(g, b, c) }); b.className = g.join(" ")
                            }
                        }, ib: function (b, e) { var c = a.a.c(e); if (null === c || c === q) c = ""; var d = a.e.firstChild(b); !d || 3 != d.nodeType || a.e.nextSibling(d) ? a.e.P(b, [s.createTextNode(c)]) : d.data = c; a.a.Bb(b) }, gb: function (a, b) { a.name = b; if (7 >= e) try { a.mergeAttributes(s.createElement("<input name='" + a.name + "'/>"), !1) } catch (c) { } }, Bb: function (a) { 9 <= e && (a = 1 == a.nodeType ? a : a.parentNode, a.style && (a.style.zoom = a.style.zoom)) }, zb: function (a) {
                            if (e) {
                                var b = a.style.width; a.style.width = 0; a.style.width =
                                    b
                            }
                        }, Qb: function (b, e) { b = a.a.c(b); e = a.a.c(e); for (var c = [], d = b; d <= e; d++)c.push(d); return c }, N: function (a) { for (var b = [], e = 0, c = a.length; e < c; e++)b.push(a[e]); return b }, Ub: 6 === e, Vb: 7 === e, ca: e, Ua: function (b, e) { for (var c = a.a.N(b.getElementsByTagName("input")).concat(a.a.N(b.getElementsByTagName("textarea"))), d = "string" == typeof e ? function (a) { return a.name === e } : function (a) { return e.test(a.name) }, g = [], f = c.length - 1; 0 <= f; f--)d(c[f]) && g.push(c[f]); return g }, Nb: function (b) {
                            return "string" == typeof b && (b = a.a.F(b)) ?
                                y && y.parse ? y.parse(b) : (new Function("return " + b))() : null
                        }, Ca: function (b, e, c) { if (!y || !y.stringify) throw Error("Cannot find JSON.stringify(). Some browsers (e.g., IE < 8) don't support it natively, but you can overcome this by adding a script reference to json2.js, downloadable from http://www.json.org/json2.js"); return y.stringify(a.a.c(b), e, c) }, Ob: function (e, c, d) {
                            d = d || {}; var g = d.params || {}, f = d.includeFields || this.Ta, p = e; if ("object" == typeof e && "form" === a.a.u(e)) for (var p = e.action, r = f.length - 1; 0 <= r; r--)for (var z =
                                a.a.Ua(e, f[r]), D = z.length - 1; 0 <= D; D--)g[z[D].name] = z[D].value; c = a.a.c(c); var q = s.createElement("form"); q.style.display = "none"; q.action = p; q.method = "post"; for (var v in c) e = s.createElement("input"), e.name = v, e.value = a.a.Ca(a.a.c(c[v])), q.appendChild(e); b(g, function (a, b) { var e = s.createElement("input"); e.name = a; e.value = b; q.appendChild(e) }); s.body.appendChild(q); d.submitter ? d.submitter(q) : q.submit(); setTimeout(function () { q.parentNode.removeChild(q) }, 0)
                        }
                    }
            }(); a.b("utils", a.a); a.b("utils.arrayForEach", a.a.p);
            a.b("utils.arrayFirst", a.a.La); a.b("utils.arrayFilter", a.a.Y); a.b("utils.arrayGetDistinctValues", a.a.Ma); a.b("utils.arrayIndexOf", a.a.k); a.b("utils.arrayMap", a.a.Z); a.b("utils.arrayPushAll", a.a.R); a.b("utils.arrayRemoveItem", a.a.ka); a.b("utils.extend", a.a.extend); a.b("utils.fieldsIncludedWithJsonPost", a.a.Ta); a.b("utils.getFormFields", a.a.Ua); a.b("utils.peekObservable", a.a.ya); a.b("utils.postJson", a.a.Ob); a.b("utils.parseJson", a.a.Nb); a.b("utils.registerEventHandler", a.a.o); a.b("utils.stringifyJson",
                a.a.Ca); a.b("utils.range", a.a.Qb); a.b("utils.toggleDomNodeCssClass", a.a.ga); a.b("utils.triggerEvent", a.a.Ga); a.b("utils.unwrapObservable", a.a.c); a.b("utils.objectForEach", a.a.w); a.b("utils.addOrRemoveItem", a.a.ja); a.b("unwrap", a.a.c); Function.prototype.bind || (Function.prototype.bind = function (a) { var c = this, d = Array.prototype.slice.call(arguments); a = d.shift(); return function () { return c.apply(a, d.concat(Array.prototype.slice.call(arguments))) } }); a.a.f = new function () {
                    var b = 0, c = "__ko__" + (new Date).getTime(),
                    d = {}; return { get: function (b, c) { var e = a.a.f.pa(b, !1); return e === q ? q : e[c] }, set: function (b, c, e) { if (e !== q || a.a.f.pa(b, !1) !== q) a.a.f.pa(b, !0)[c] = e }, pa: function (a, g) { var e = a[c]; if (!e || "null" === e || !d[e]) { if (!g) return q; e = a[c] = "ko" + b++; d[e] = {} } return d[e] }, clear: function (a) { var b = a[c]; return b ? (delete d[b], a[c] = null, !0) : !1 } }
                }; a.b("utils.domData", a.a.f); a.b("utils.domData.clear", a.a.f.clear); a.a.C = new function () {
                    function b(b, c) { var g = a.a.f.get(b, d); g === q && c && (g = [], a.a.f.set(b, d, g)); return g } function c(e) {
                        var d =
                            b(e, !1); if (d) for (var d = d.slice(0), f = 0; f < d.length; f++)d[f](e); a.a.f.clear(e); "function" == typeof t && "function" == typeof t.cleanData && t.cleanData([e]); if (g[e.nodeType]) for (d = e.firstChild; e = d;)d = e.nextSibling, 8 === e.nodeType && c(e)
                    } var d = "__ko_domNodeDisposal__" + (new Date).getTime(), f = { 1: !0, 8: !0, 9: !0 }, g = { 1: !0, 9: !0 }; return {
                        ia: function (a, c) { if ("function" != typeof c) throw Error("Callback must be a function"); b(a, !0).push(c) }, cb: function (e, c) { var g = b(e, !1); g && (a.a.ka(g, c), 0 == g.length && a.a.f.set(e, d, q)) }, H: function (b) {
                            if (f[b.nodeType] &&
                                (c(b), g[b.nodeType])) { var d = []; a.a.R(d, b.getElementsByTagName("*")); for (var h = 0, k = d.length; h < k; h++)c(d[h]) } return b
                        }, removeNode: function (b) { a.H(b); b.parentNode && b.parentNode.removeChild(b) }
                    }
                }; a.H = a.a.C.H; a.removeNode = a.a.C.removeNode; a.b("cleanNode", a.H); a.b("removeNode", a.removeNode); a.b("utils.domNodeDisposal", a.a.C); a.b("utils.domNodeDisposal.addDisposeCallback", a.a.C.ia); a.b("utils.domNodeDisposal.removeDisposeCallback", a.a.C.cb); (function () {
                    a.a.xa = function (b) {
                        var c; if ("undefined" != typeof t) if (t.parseHTML) c =
                            t.parseHTML(b) || []; else { if ((c = t.clean([b])) && c[0]) { for (b = c[0]; b.parentNode && 11 !== b.parentNode.nodeType;)b = b.parentNode; b.parentNode && b.parentNode.removeChild(b) } } else {
                                var d = a.a.F(b).toLowerCase(); c = s.createElement("div"); d = d.match(/^<(thead|tbody|tfoot)/) && [1, "<table>", "</table>"] || !d.indexOf("<tr") && [2, "<table><tbody>", "</tbody></table>"] || (!d.indexOf("<td") || !d.indexOf("<th")) && [3, "<table><tbody><tr>", "</tr></tbody></table>"] || [0, "", ""]; b = "ignored<div>" + d[1] + b + d[2] + "</div>"; for ("function" == typeof w.innerShiv ?
                                    c.appendChild(w.innerShiv(b)) : c.innerHTML = b; d[0]--;)c = c.lastChild; c = a.a.N(c.lastChild.childNodes)
                        } return c
                    }; a.a.fa = function (b, c) { a.a.oa(b); c = a.a.c(c); if (null !== c && c !== q) if ("string" != typeof c && (c = c.toString()), "undefined" != typeof t) t(b).html(c); else for (var d = a.a.xa(c), f = 0; f < d.length; f++)b.appendChild(d[f]) }
                })(); a.b("utils.parseHtmlFragment", a.a.xa); a.b("utils.setHtml", a.a.fa); a.s = function () {
                    function b(c, f) {
                        if (c) if (8 == c.nodeType) { var g = a.s.$a(c.nodeValue); null != g && f.push({ xb: c, Kb: g }) } else if (1 == c.nodeType) for (var g =
                            0, e = c.childNodes, m = e.length; g < m; g++)b(e[g], f)
                    } var c = {}; return {
                        va: function (a) { if ("function" != typeof a) throw Error("You can only pass a function to ko.memoization.memoize()"); var b = (4294967296 * (1 + Math.random()) | 0).toString(16).substring(1) + (4294967296 * (1 + Math.random()) | 0).toString(16).substring(1); c[b] = a; return "\x3c!--[ko_memo:" + b + "]--\x3e" }, mb: function (a, b) {
                            var g = c[a]; if (g === q) throw Error("Couldn't find any memo with ID " + a + ". Perhaps it's already been unmemoized."); try {
                                return g.apply(null, b || []),
                                    !0
                            } finally { delete c[a] }
                        }, nb: function (c, f) { var g = []; b(c, g); for (var e = 0, m = g.length; e < m; e++) { var h = g[e].xb, k = [h]; f && a.a.R(k, f); a.s.mb(g[e].Kb, k); h.nodeValue = ""; h.parentNode && h.parentNode.removeChild(h) } }, $a: function (a) { return (a = a.match(/^\[ko_memo\:(.*?)\]$/)) ? a[1] : null }
                    }
                }(); a.b("memoization", a.s); a.b("memoization.memoize", a.s.va); a.b("memoization.unmemoize", a.s.mb); a.b("memoization.parseMemoText", a.s.$a); a.b("memoization.unmemoizeDomNodeAndDescendants", a.s.nb); a.Sa = {
                    throttle: function (b, c) {
                    b.throttleEvaluation =
                        c; var d = null; return a.j({ read: b, write: function (a) { clearTimeout(d); d = setTimeout(function () { b(a) }, c) } })
                    }, notify: function (b, c) { b.equalityComparer = "always" == c ? F(!1) : a.m.fn.equalityComparer; return b }
                }; a.b("extenders", a.Sa); a.kb = function (b, c, d) { this.target = b; this.la = c; this.wb = d; a.r(this, "dispose", this.B) }; a.kb.prototype.B = function () { this.Hb = !0; this.wb() }; a.V = function () { this.G = {}; a.a.extend(this, a.V.fn); a.r(this, "subscribe", this.Da); a.r(this, "extend", this.extend); a.r(this, "getSubscriptionsCount", this.Db) };
            a.V.fn = { Da: function (b, c, d) { d = d || "change"; var f = new a.kb(this, c ? b.bind(c) : b, function () { a.a.ka(this.G[d], f) }.bind(this)); this.G[d] || (this.G[d] = []); this.G[d].push(f); return f }, notifySubscribers: function (b, c) { c = c || "change"; this.G[c] && a.q.I(function () { a.a.p(this.G[c].slice(0), function (a) { a && !0 !== a.Hb && a.la(b) }) }, this) }, Db: function () { var b = 0; a.a.w(this.G, function (a, d) { b += d.length }); return b }, extend: function (b) { var c = this; b && a.a.w(b, function (b, f) { var g = a.Sa[b]; "function" == typeof g && (c = g(c, f)) }); return c } };
            a.Wa = function (a) { return null != a && "function" == typeof a.Da && "function" == typeof a.notifySubscribers }; a.b("subscribable", a.V); a.b("isSubscribable", a.Wa); a.q = function () { var b = []; return { rb: function (a) { b.push({ la: a, Ra: [] }) }, end: function () { b.pop() }, bb: function (c) { if (!a.Wa(c)) throw Error("Only subscribable things can act as dependencies"); if (0 < b.length) { var d = b[b.length - 1]; !d || 0 <= a.a.k(d.Ra, c) || (d.Ra.push(c), d.la(c)) } }, I: function (a, d, f) { try { return b.push(null), a.apply(d, f || []) } finally { b.pop() } } } }(); var L =
                { undefined: !0, "boolean": !0, number: !0, string: !0 }; a.m = function (b) { function c() { if (0 < arguments.length) return c.equalityComparer && c.equalityComparer(d, arguments[0]) || (c.K(), d = arguments[0], c.J()), this; a.q.bb(c); return d } var d = b; a.V.call(c); c.t = function () { return d }; c.J = function () { c.notifySubscribers(d) }; c.K = function () { c.notifySubscribers(d, "beforeChange") }; a.a.extend(c, a.m.fn); a.r(c, "peek", c.t); a.r(c, "valueHasMutated", c.J); a.r(c, "valueWillMutate", c.K); return c }; a.m.fn = {
                    equalityComparer: function (a, c) {
                        return null ===
                            a || typeof a in L ? a === c : !1
                    }
                }; var A = a.m.Pb = "__ko_proto__"; a.m.fn[A] = a.m; a.qa = function (b, c) { return null === b || b === q || b[A] === q ? !1 : b[A] === c ? !0 : a.qa(b[A], c) }; a.T = function (b) { return a.qa(b, a.m) }; a.Xa = function (b) { return "function" == typeof b && b[A] === a.m || "function" == typeof b && b[A] === a.j && b.Eb ? !0 : !1 }; a.b("observable", a.m); a.b("isObservable", a.T); a.b("isWriteableObservable", a.Xa); a.U = function (b) {
                    b = b || []; if ("object" != typeof b || !("length" in b)) throw Error("The argument passed when initializing an observable array must be an array, or null, or undefined.");
                    b = a.m(b); a.a.extend(b, a.U.fn); return b
                }; a.U.fn = {
                    remove: function (a) { for (var c = this.t(), d = [], f = "function" == typeof a ? a : function (e) { return e === a }, g = 0; g < c.length; g++) { var e = c[g]; f(e) && (0 === d.length && this.K(), d.push(e), c.splice(g, 1), g--) } d.length && this.J(); return d }, removeAll: function (b) { if (b === q) { var c = this.t(), d = c.slice(0); this.K(); c.splice(0, c.length); this.J(); return d } return b ? this.remove(function (c) { return 0 <= a.a.k(b, c) }) : [] }, destroy: function (a) {
                        var c = this.t(), d = "function" == typeof a ? a : function (c) {
                            return c ===
                                a
                        }; this.K(); for (var f = c.length - 1; 0 <= f; f--)d(c[f]) && (c[f]._destroy = !0); this.J()
                    }, destroyAll: function (b) { return b === q ? this.destroy(F(!0)) : b ? this.destroy(function (c) { return 0 <= a.a.k(b, c) }) : [] }, indexOf: function (b) { var c = this(); return a.a.k(c, b) }, replace: function (a, c) { var d = this.indexOf(a); 0 <= d && (this.K(), this.t()[d] = c, this.J()) }
                }; a.a.p("pop push reverse shift sort splice unshift".split(" "), function (b) { a.U.fn[b] = function () { var a = this.t(); this.K(); a = a[b].apply(a, arguments); this.J(); return a } }); a.a.p(["slice"],
                    function (b) { a.U.fn[b] = function () { var a = this(); return a[b].apply(a, arguments) } }); a.b("observableArray", a.U); a.j = function (b, c, d) {
                        function f() { a.a.p(v, function (a) { a.B() }); v = [] } function g() { var a = m.throttleEvaluation; a && 0 <= a ? (clearTimeout(t), t = setTimeout(e, a)) : e() } function e() {
                            if (!n) if (l && D()) x(); else {
                                n = !0; try {
                                    var b = a.a.Z(v, function (a) { return a.target }); a.q.rb(function (e) { var c; 0 <= (c = a.a.k(b, e)) ? b[c] = q : v.push(e.Da(g)) }); for (var e = p.call(c), d = b.length - 1; 0 <= d; d--)b[d] && v.splice(d, 1)[0].B(); l = !0; m.notifySubscribers(k,
                                        "beforeChange"); k = e; m.notifySubscribers(k)
                                } finally { a.q.end(), n = !1 } v.length || x()
                            }
                        } function m() { if (0 < arguments.length) { if ("function" === typeof r) r.apply(c, arguments); else throw Error("Cannot write a value to a ko.computed unless you specify a 'write' option. If you wish to read the current value, don't pass any parameters."); return this } l || e(); a.q.bb(m); return k } function h() { return !l || 0 < v.length } var k, l = !1, n = !1, p = b; p && "object" == typeof p ? (d = p, p = d.read) : (d = d || {}, p || (p = d.read)); if ("function" != typeof p) throw Error("Pass a function that returns the value of the ko.computed");
                        var r = d.write, z = d.disposeWhenNodeIsRemoved || d.$ || null, D = d.disposeWhen || d.Qa || F(!1), x = f, v = [], t = null; c || (c = d.owner); m.t = function () { l || e(); return k }; m.Cb = function () { return v.length }; m.Eb = "function" === typeof d.write; m.B = function () { x() }; m.ta = h; a.V.call(m); a.a.extend(m, a.j.fn); a.r(m, "peek", m.t); a.r(m, "dispose", m.B); a.r(m, "isActive", m.ta); a.r(m, "getDependenciesCount", m.Cb); !0 !== d.deferEvaluation && e(); if (z && h()) { x = function () { a.a.C.cb(z, x); f() }; a.a.C.ia(z, x); var s = D, D = function () { return !a.a.aa(z) || s() } } return m
                    };
            a.Gb = function (b) { return a.qa(b, a.j) }; C = a.m.Pb; a.j[C] = a.m; a.j.fn = {}; a.j.fn[C] = a.j; a.b("dependentObservable", a.j); a.b("computed", a.j); a.b("isComputed", a.Gb); (function () {
                function b(a, g, e) {
                    e = e || new d; a = g(a); if ("object" != typeof a || null === a || a === q || a instanceof Date || a instanceof String || a instanceof Number || a instanceof Boolean) return a; var m = a instanceof Array ? [] : {}; e.save(a, m); c(a, function (c) {
                        var d = g(a[c]); switch (typeof d) {
                            case "boolean": case "number": case "string": case "function": m[c] = d; break; case "object": case "undefined": var l =
                                e.get(d); m[c] = l !== q ? l : b(d, g, e)
                        }
                    }); return m
                } function c(a, b) { if (a instanceof Array) { for (var e = 0; e < a.length; e++)b(e); "function" == typeof a.toJSON && b("toJSON") } else for (e in a) b(e) } function d() { this.keys = []; this.Ha = [] } a.lb = function (c) { if (0 == arguments.length) throw Error("When calling ko.toJS, pass the object you want to convert."); return b(c, function (b) { for (var e = 0; a.T(b) && 10 > e; e++)b = b(); return b }) }; a.toJSON = function (b, c, e) { b = a.lb(b); return a.a.Ca(b, c, e) }; d.prototype = {
                    save: function (b, c) {
                        var e = a.a.k(this.keys,
                            b); 0 <= e ? this.Ha[e] = c : (this.keys.push(b), this.Ha.push(c))
                    }, get: function (b) { b = a.a.k(this.keys, b); return 0 <= b ? this.Ha[b] : q }
                }
            })(); a.b("toJS", a.lb); a.b("toJSON", a.toJSON); (function () {
            a.h = {
                n: function (b) { switch (a.a.u(b)) { case "option": return !0 === b.__ko__hasDomDataOptionValue__ ? a.a.f.get(b, a.d.options.wa) : 7 >= a.a.ca ? b.getAttributeNode("value") && b.getAttributeNode("value").specified ? b.value : b.text : b.value; case "select": return 0 <= b.selectedIndex ? a.h.n(b.options[b.selectedIndex]) : q; default: return b.value } }, W: function (b,
                    c) {
                        switch (a.a.u(b)) {
                            case "option": switch (typeof c) { case "string": a.a.f.set(b, a.d.options.wa, q); "__ko__hasDomDataOptionValue__" in b && delete b.__ko__hasDomDataOptionValue__; b.value = c; break; default: a.a.f.set(b, a.d.options.wa, c), b.__ko__hasDomDataOptionValue__ = !0, b.value = "number" === typeof c ? c : "" }break; case "select": "" === c && (c = q); if (null === c || c === q) b.selectedIndex = -1; for (var d = b.options.length - 1; 0 <= d; d--)if (a.h.n(b.options[d]) == c) { b.selectedIndex = d; break } 1 < b.size || -1 !== b.selectedIndex || (b.selectedIndex =
                                0); break; default: if (null === c || c === q) c = ""; b.value = c
                        }
                }
            }
            })(); a.b("selectExtensions", a.h); a.b("selectExtensions.readValue", a.h.n); a.b("selectExtensions.writeValue", a.h.W); a.g = function () {
                function b(a, b) { for (var d = null; a != d;)d = a, a = a.replace(c, function (a, c) { return b[c] }); return a } var c = /\@ko_token_(\d+)\@/g, d = ["true", "false", "null", "undefined"], f = /^(?:[$_a-z][$\w]*|(.+)(\.\s*[$_a-z][$\w]*|\[.+\]))$/i; return {
                    S: [], da: function (c) {
                        var e = a.a.F(c); if (3 > e.length) return []; "{" === e.charAt(0) && (e = e.substring(1, e.length -
                            1)); c = []; for (var d = null, f, k = 0; k < e.length; k++) { var l = e.charAt(k); if (null === d) switch (l) { case '"': case "'": case "/": d = k, f = l } else if (l == f && "\\" !== e.charAt(k - 1)) { l = e.substring(d, k + 1); c.push(l); var n = "@ko_token_" + (c.length - 1) + "@", e = e.substring(0, d) + n + e.substring(k + 1), k = k - (l.length - n.length), d = null } } f = d = null; for (var p = 0, r = null, k = 0; k < e.length; k++) {
                                l = e.charAt(k); if (null === d) switch (l) { case "{": d = k; r = l; f = "}"; break; case "(": d = k; r = l; f = ")"; break; case "[": d = k, r = l, f = "]" }l === r ? p++ : l === f && (p-- , 0 === p && (l = e.substring(d,
                                    k + 1), c.push(l), n = "@ko_token_" + (c.length - 1) + "@", e = e.substring(0, d) + n + e.substring(k + 1), k -= l.length - n.length, d = null))
                            } f = []; e = e.split(","); d = 0; for (k = e.length; d < k; d++)p = e[d], r = p.indexOf(":"), 0 < r && r < p.length - 1 ? (l = p.substring(r + 1), f.push({ key: b(p.substring(0, r), c), value: b(l, c) })) : f.push({ unknown: b(p, c) }); return f
                    }, ea: function (b) {
                        var e = "string" === typeof b ? a.g.da(b) : b, c = []; b = []; for (var h, k = 0; h = e[k]; k++)if (0 < c.length && c.push(","), h.key) {
                            var l; a: {
                                l = h.key; var n = a.a.F(l); switch (n.length && n.charAt(0)) {
                                    case "'": case '"': break a;
                                    default: l = "'" + n + "'"
                                }
                            } h = h.value; c.push(l); c.push(":"); c.push(h); h = a.a.F(h); 0 <= a.a.k(d, a.a.F(h).toLowerCase()) ? h = !1 : (n = h.match(f), h = null === n ? !1 : n[1] ? "Object(" + n[1] + ")" + n[2] : h); h && (0 < b.length && b.push(", "), b.push(l + " : function(__ko_value) { " + h + " = __ko_value; }"))
                        } else h.unknown && c.push(h.unknown); e = c.join(""); 0 < b.length && (e = e + ", '_ko_property_writers' : { " + b.join("") + " } "); return e
                    }, Jb: function (b, c) { for (var d = 0; d < b.length; d++)if (a.a.F(b[d].key) == c) return !0; return !1 }, ha: function (b, c, d, f, k) {
                        if (b &&
                            a.T(b)) !a.Xa(b) || k && b.t() === f || b(f); else if ((b = c()._ko_property_writers) && b[d]) b[d](f)
                    }
                }
            }(); a.b("expressionRewriting", a.g); a.b("expressionRewriting.bindingRewriteValidators", a.g.S); a.b("expressionRewriting.parseObjectLiteral", a.g.da); a.b("expressionRewriting.preProcessBindings", a.g.ea); a.b("jsonExpressionRewriting", a.g); a.b("jsonExpressionRewriting.insertPropertyAccessorsIntoJson", a.g.ea); (function () {
                function b(a) { return 8 == a.nodeType && (g ? a.text : a.nodeValue).match(e) } function c(a) {
                    return 8 == a.nodeType &&
                        (g ? a.text : a.nodeValue).match(m)
                } function d(a, e) { for (var d = a, g = 1, f = []; d = d.nextSibling;) { if (c(d) && (g-- , 0 === g)) return f; f.push(d); b(d) && g++ } if (!e) throw Error("Cannot find closing comment tag to match: " + a.nodeValue); return null } function f(a, b) { var c = d(a, b); return c ? 0 < c.length ? c[c.length - 1].nextSibling : a.nextSibling : null } var g = s && "\x3c!--test--\x3e" === s.createComment("test").text, e = g ? /^\x3c!--\s*ko(?:\s+(.+\s*\:[\s\S]*))?\s*--\x3e$/ : /^\s*ko(?:\s+(.+\s*\:[\s\S]*))?\s*$/, m = g ? /^\x3c!--\s*\/ko\s*--\x3e$/ :
                    /^\s*\/ko\s*$/, h = { ul: !0, ol: !0 }; a.e = {
                        L: {}, childNodes: function (a) { return b(a) ? d(a) : a.childNodes }, ba: function (c) { if (b(c)) { c = a.e.childNodes(c); for (var e = 0, d = c.length; e < d; e++)a.removeNode(c[e]) } else a.a.oa(c) }, P: function (c, e) { if (b(c)) { a.e.ba(c); for (var d = c.nextSibling, g = 0, f = e.length; g < f; g++)d.parentNode.insertBefore(e[g], d) } else a.a.P(c, e) }, ab: function (a, c) { b(a) ? a.parentNode.insertBefore(c, a.nextSibling) : a.firstChild ? a.insertBefore(c, a.firstChild) : a.appendChild(c) }, Va: function (c, e, d) {
                            d ? b(c) ? c.parentNode.insertBefore(e,
                                d.nextSibling) : d.nextSibling ? c.insertBefore(e, d.nextSibling) : c.appendChild(e) : a.e.ab(c, e)
                        }, firstChild: function (a) { return b(a) ? !a.nextSibling || c(a.nextSibling) ? null : a.nextSibling : a.firstChild }, nextSibling: function (a) { b(a) && (a = f(a)); return a.nextSibling && c(a.nextSibling) ? null : a.nextSibling }, ob: function (a) { return (a = b(a)) ? a[1] : null }, Za: function (e) {
                            if (h[a.a.u(e)]) {
                                var d = e.firstChild; if (d) {
                                    do if (1 === d.nodeType) {
                                        var g; g = d.firstChild; var m = null; if (g) {
                                            do if (m) m.push(g); else if (b(g)) {
                                                var r = f(g, !0); r ? g = r : m =
                                                    [g]
                                            } else c(g) && (m = [g]); while (g = g.nextSibling)
                                        } if (g = m) for (m = d.nextSibling, r = 0; r < g.length; r++)m ? e.insertBefore(g[r], m) : e.appendChild(g[r])
                                    } while (d = d.nextSibling)
                                }
                            }
                        }
                    }
            })(); a.b("virtualElements", a.e); a.b("virtualElements.allowedBindings", a.e.L); a.b("virtualElements.emptyNode", a.e.ba); a.b("virtualElements.insertAfter", a.e.Va); a.b("virtualElements.prepend", a.e.ab); a.b("virtualElements.setDomNodeChildren", a.e.P); (function () {
            a.M = function () { this.Na = {} }; a.a.extend(a.M.prototype, {
                nodeHasBindings: function (b) {
                    switch (b.nodeType) {
                        case 1: return null !=
                            b.getAttribute("data-bind"); case 8: return null != a.e.ob(b); default: return !1
                    }
                }, getBindings: function (a, c) { var d = this.getBindingsString(a, c); return d ? this.parseBindingsString(d, c, a) : null }, getBindingsString: function (b) { switch (b.nodeType) { case 1: return b.getAttribute("data-bind"); case 8: return a.e.ob(b); default: return null } }, parseBindingsString: function (b, c, d) {
                    try {
                        var f; if (!(f = this.Na[b])) {
                            var g = this.Na, e, m = "with($context){with($data||{}){return{" + a.g.ea(b) + "}}}"; e = new Function("$context", "$element", m);
                            f = g[b] = e
                        } return f(c, d)
                    } catch (h) { throw h.message = "Unable to parse bindings.\nBindings value: " + b + "\nMessage: " + h.message, h; }
                }
            }); a.M.instance = new a.M
            })(); a.b("bindingProvider", a.M); (function () {
                function b(b, e, d) { for (var f = a.e.firstChild(e); e = f;)f = a.e.nextSibling(e), c(b, e, d) } function c(c, e, f) { var h = !0, k = 1 === e.nodeType; k && a.e.Za(e); if (k && f || a.M.instance.nodeHasBindings(e)) h = d(e, null, c, f).Sb; h && b(c, e, !k) } function d(b, c, d, h) {
                    function k(a) { return function () { return p[a] } } function l() { return p } var n = 0, p, r,
                        z = a.a.f.get(b, f); if (!c) { if (z) throw Error("You cannot apply bindings multiple times to the same element."); a.a.f.set(b, f, !0) } a.j(function () {
                            var f = d && d instanceof a.A ? d : new a.A(a.a.c(d)), x = f.$data; !z && h && a.jb(b, f); if (p = ("function" == typeof c ? c(f, b) : c) || a.M.instance.getBindings(b, f)) 0 === n && (n = 1, a.a.w(p, function (c) {
                                var e = a.d[c]; if (e && 8 === b.nodeType && !a.e.L[c]) throw Error("The binding '" + c + "' cannot be used with virtual elements"); if (e && "function" == typeof e.init && (e = (0, e.init)(b, k(c), l, x, f)) && e.controlsDescendantBindings) {
                                    if (r !==
                                        q) throw Error("Multiple bindings (" + r + " and " + c + ") are trying to control descendant bindings of the same element. You cannot use these bindings together on the same element."); r = c
                                }
                            }), n = 2), 2 === n && a.a.w(p, function (c) { var e = a.d[c]; e && "function" == typeof e.update && (0, e.update)(b, k(c), l, x, f) })
                        }, null, { $: b }); return { Sb: r === q }
                } a.d = {}; a.A = function (b, c, d) {
                    c ? (a.a.extend(this, c), this.$parentContext = c, this.$parent = c.$data, this.$parents = (c.$parents || []).slice(0), this.$parents.unshift(this.$parent)) : (this.$parents =
                        [], this.$root = b, this.ko = a); this.$data = b; d && (this[d] = b)
                }; a.A.prototype.createChildContext = function (b, c) { return new a.A(b, this, c) }; a.A.prototype.extend = function (b) { var c = a.a.extend(new a.A, this); return a.a.extend(c, b) }; var f = "__ko_boundElement"; a.jb = function (b, c) { if (2 == arguments.length) a.a.f.set(b, "__ko_bindingContext__", c); else return a.a.f.get(b, "__ko_bindingContext__") }; a.Ka = function (b, c, f) { 1 === b.nodeType && a.e.Za(b); return d(b, c, f, !0) }; a.Ja = function (a, c) { 1 !== c.nodeType && 8 !== c.nodeType || b(a, c, !0) };
                a.Ia = function (a, b) { if (b && 1 !== b.nodeType && 8 !== b.nodeType) throw Error("ko.applyBindings: first parameter should be your view model; second parameter should be a DOM node"); b = b || w.document.body; c(a, b, !0) }; a.na = function (b) { switch (b.nodeType) { case 1: case 8: var c = a.jb(b); if (c) return c; if (b.parentNode) return a.na(b.parentNode) }return q }; a.ub = function (b) { return (b = a.na(b)) ? b.$data : q }; a.b("bindingHandlers", a.d); a.b("applyBindings", a.Ia); a.b("applyBindingsToDescendants", a.Ja); a.b("applyBindingsToNode", a.Ka);
                a.b("contextFor", a.na); a.b("dataFor", a.ub)
            })(); var K = { "class": "className", "for": "htmlFor" }; a.d.attr = { update: function (b, c) { var d = a.a.c(c()) || {}; a.a.w(d, function (c, d) { d = a.a.c(d); var e = !1 === d || null === d || d === q; e && b.removeAttribute(c); 8 >= a.a.ca && c in K ? (c = K[c], e ? b.removeAttribute(c) : b[c] = d) : e || b.setAttribute(c, d.toString()); "name" === c && a.a.gb(b, e ? "" : d.toString()) }) } }; a.d.checked = {
                init: function (b, c, d) {
                    a.a.o(b, "click", function () {
                        var f; if ("checkbox" == b.type) f = b.checked; else if ("radio" == b.type && b.checked) f =
                            b.value; else return; var g = c(), e = a.a.c(g); "checkbox" == b.type && e instanceof Array ? a.a.ja(g, b.value, b.checked) : a.g.ha(g, d, "checked", f, !0)
                    }); "radio" != b.type || b.name || a.d.uniqueName.init(b, F(!0))
                }, update: function (b, c) { var d = a.a.c(c()); "checkbox" == b.type ? b.checked = d instanceof Array ? 0 <= a.a.k(d, b.value) : d : "radio" == b.type && (b.checked = b.value == d) }
            }; a.d.css = {
                update: function (b, c) {
                    var d = a.a.c(c()); "object" == typeof d ? a.a.w(d, function (c, d) { d = a.a.c(d); a.a.ga(b, c, d) }) : (d = String(d || ""), a.a.ga(b, b.__ko__cssValue, !1),
                        b.__ko__cssValue = d, a.a.ga(b, d, !0))
                }
            }; a.d.enable = { update: function (b, c) { var d = a.a.c(c()); d && b.disabled ? b.removeAttribute("disabled") : d || b.disabled || (b.disabled = !0) } }; a.d.disable = { update: function (b, c) { a.d.enable.update(b, function () { return !a.a.c(c()) }) } }; a.d.event = {
                init: function (b, c, d, f) {
                    var g = c() || {}; a.a.w(g, function (e) {
                    "string" == typeof e && a.a.o(b, e, function (b) {
                        var g, k = c()[e]; if (k) {
                            var l = d(); try { var n = a.a.N(arguments); n.unshift(f); g = k.apply(f, n) } finally {
                            !0 !== g && (b.preventDefault ? b.preventDefault() : b.returnValue =
                                !1)
                            } !1 === l[e + "Bubble"] && (b.cancelBubble = !0, b.stopPropagation && b.stopPropagation())
                        }
                    })
                    })
                }
            }; a.d.foreach = {
                Ya: function (b) { return function () { var c = b(), d = a.a.ya(c); if (!d || "number" == typeof d.length) return { foreach: c, templateEngine: a.D.sa }; a.a.c(c); return { foreach: d.data, as: d.as, includeDestroyed: d.includeDestroyed, afterAdd: d.afterAdd, beforeRemove: d.beforeRemove, afterRender: d.afterRender, beforeMove: d.beforeMove, afterMove: d.afterMove, templateEngine: a.D.sa } } }, init: function (b, c) { return a.d.template.init(b, a.d.foreach.Ya(c)) },
                update: function (b, c, d, f, g) { return a.d.template.update(b, a.d.foreach.Ya(c), d, f, g) }
            }; a.g.S.foreach = !1; a.e.L.foreach = !0; a.d.hasfocus = {
                init: function (b, c, d) { function f(e) { b.__ko_hasfocusUpdating = !0; var f = b.ownerDocument; if ("activeElement" in f) { var g; try { g = f.activeElement } catch (l) { g = f.body } e = g === b } f = c(); a.g.ha(f, d, "hasfocus", e, !0); b.__ko_hasfocusLastValue = e; b.__ko_hasfocusUpdating = !1 } var g = f.bind(null, !0), e = f.bind(null, !1); a.a.o(b, "focus", g); a.a.o(b, "focusin", g); a.a.o(b, "blur", e); a.a.o(b, "focusout", e) },
                update: function (b, c) { var d = !!a.a.c(c()); b.__ko_hasfocusUpdating || b.__ko_hasfocusLastValue === d || (d ? b.focus() : b.blur(), a.q.I(a.a.Ga, null, [b, d ? "focusin" : "focusout"])) }
            }; a.d.hasFocus = a.d.hasfocus; a.d.html = { init: function () { return { controlsDescendantBindings: !0 } }, update: function (b, c) { a.a.fa(b, c()) } }; var I = "__ko_withIfBindingData"; G("if"); G("ifnot", !1, !0); G("with", !0, !1, function (a, c) { return a.createChildContext(c) }); a.d.options = {
                init: function (b) {
                    if ("select" !== a.a.u(b)) throw Error("options binding applies only to SELECT elements");
                    for (; 0 < b.length;)b.remove(0); return { controlsDescendantBindings: !0 }
                }, update: function (b, c, d) {
                    function f(a, b, c) { var d = typeof b; return "function" == d ? b(a) : "string" == d ? a[b] : c } function g(b, c) { if (p) { var d = 0 <= a.a.k(p, a.h.n(c[0])); a.a.hb(c[0], d) } } var e = 0 == b.length, m = !e && b.multiple ? b.scrollTop : null; c = a.a.c(c()); var h = d(), k = h.optionsIncludeDestroyed, l = {}, n, p; b.multiple ? p = a.a.Z(b.selectedOptions || a.a.Y(b.childNodes, function (b) { return b.tagName && "option" === a.a.u(b) && b.selected }), function (b) { return a.h.n(b) }) : 0 <=
                        b.selectedIndex && (p = [a.h.n(b.options[b.selectedIndex])]); if (c) { "undefined" == typeof c.length && (c = [c]); var r = a.a.Y(c, function (b) { return k || b === q || null === b || !a.a.c(b._destroy) }); "optionsCaption" in h && (n = a.a.c(h.optionsCaption), null !== n && n !== q && r.unshift(l)) } else c = []; d = g; h.optionsAfterRender && (d = function (b, c) { g(0, c); a.q.I(h.optionsAfterRender, null, [c[0], b !== l ? b : q]) }); a.a.Aa(b, r, function (b, c, d) {
                        d.length && (p = d[0].selected && [a.h.n(d[0])]); c = s.createElement("option"); b === l ? (a.a.fa(c, n), a.h.W(c, q)) : (d = f(b,
                            h.optionsValue, b), a.h.W(c, a.a.c(d)), b = f(b, h.optionsText, d), a.a.ib(c, b)); return [c]
                        }, null, d); p = null; e && "value" in h && J(b, a.a.ya(h.value), !0); a.a.zb(b); m && 20 < Math.abs(m - b.scrollTop) && (b.scrollTop = m)
                }
            }; a.d.options.wa = "__ko.optionValueDomData__"; a.d.selectedOptions = {
                init: function (b, c, d) { a.a.o(b, "change", function () { var f = c(), g = []; a.a.p(b.getElementsByTagName("option"), function (b) { b.selected && g.push(a.h.n(b)) }); a.g.ha(f, d, "selectedOptions", g) }) }, update: function (b, c) {
                    if ("select" != a.a.u(b)) throw Error("values binding applies only to SELECT elements");
                    var d = a.a.c(c()); d && "number" == typeof d.length && a.a.p(b.getElementsByTagName("option"), function (b) { var c = 0 <= a.a.k(d, a.h.n(b)); a.a.hb(b, c) })
                }
            }; a.d.style = { update: function (b, c) { var d = a.a.c(c() || {}); a.a.w(d, function (c, d) { d = a.a.c(d); b.style[c] = d || "" }) } }; a.d.submit = { init: function (b, c, d, f) { if ("function" != typeof c()) throw Error("The value for a submit binding must be a function"); a.a.o(b, "submit", function (a) { var d, m = c(); try { d = m.call(f, b) } finally { !0 !== d && (a.preventDefault ? a.preventDefault() : a.returnValue = !1) } }) } };
            a.d.text = { update: function (b, c) { a.a.ib(b, c()) } }; a.e.L.text = !0; a.d.uniqueName = { init: function (b, c) { if (c()) { var d = "ko_unique_" + ++a.d.uniqueName.tb; a.a.gb(b, d) } } }; a.d.uniqueName.tb = 0; a.d.value = {
                init: function (b, c, d) {
                    function f() { m = !1; var e = c(), f = a.h.n(b); a.g.ha(e, d, "value", f) } var g = ["change"], e = d().valueUpdate, m = !1; e && ("string" == typeof e && (e = [e]), a.a.R(g, e), g = a.a.Ma(g)); !a.a.ca || ("input" != b.tagName.toLowerCase() || "text" != b.type || "off" == b.autocomplete || b.form && "off" == b.form.autocomplete) || -1 != a.a.k(g, "propertychange") ||
                        (a.a.o(b, "propertychange", function () { m = !0 }), a.a.o(b, "blur", function () { m && f() })); a.a.p(g, function (c) { var d = f; a.a.Tb(c, "after") && (d = function () { setTimeout(f, 0) }, c = c.substring(5)); a.a.o(b, c, d) })
                }, update: function (b, c) { var d = "select" === a.a.u(b), f = a.a.c(c()), g = a.h.n(b); f !== g && (g = function () { a.h.W(b, f) }, g(), d && setTimeout(g, 0)); d && 0 < b.length && J(b, f, !1) }
            }; a.d.visible = { update: function (b, c) { var d = a.a.c(c()), f = "none" != b.style.display; d && !f ? b.style.display = "" : !d && f && (b.style.display = "none") } }; (function (b) {
            a.d[b] =
                { init: function (c, d, f, g) { return a.d.event.init.call(this, c, function () { var a = {}; a[b] = d(); return a }, f, g) } }
            })("click"); a.v = function () { }; a.v.prototype.renderTemplateSource = function () { throw Error("Override renderTemplateSource"); }; a.v.prototype.createJavaScriptEvaluatorBlock = function () { throw Error("Override createJavaScriptEvaluatorBlock"); }; a.v.prototype.makeTemplateSource = function (b, c) {
                if ("string" == typeof b) { c = c || s; var d = c.getElementById(b); if (!d) throw Error("Cannot find template with ID " + b); return new a.l.i(d) } if (1 ==
                    b.nodeType || 8 == b.nodeType) return new a.l.Q(b); throw Error("Unknown template type: " + b);
            }; a.v.prototype.renderTemplate = function (a, c, d, f) { a = this.makeTemplateSource(a, f); return this.renderTemplateSource(a, c, d) }; a.v.prototype.isTemplateRewritten = function (a, c) { return !1 === this.allowTemplateRewriting ? !0 : this.makeTemplateSource(a, c).data("isRewritten") }; a.v.prototype.rewriteTemplate = function (a, c, d) { a = this.makeTemplateSource(a, d); c = c(a.text()); a.text(c); a.data("isRewritten", !0) }; a.b("templateEngine", a.v);
            a.Ea = function () {
                function b(b, c, d, m) { b = a.g.da(b); for (var h = a.g.S, k = 0; k < b.length; k++) { var l = b[k].key; if (h.hasOwnProperty(l)) { var n = h[l]; if ("function" === typeof n) { if (l = n(b[k].value)) throw Error(l); } else if (!n) throw Error("This template engine does not support the '" + l + "' binding within its templates"); } } d = "ko.__tr_ambtns(function($context,$element){return(function(){return{ " + a.g.ea(b) + " } })()},'" + d.toLowerCase() + "')"; return m.createJavaScriptEvaluatorBlock(d) + c } var c = /(<([a-z]+\d*)(?:\s+(?!data-bind\s*=\s*)[a-z0-9\-]+(?:=(?:\"[^\"]*\"|\'[^\']*\'))?)*\s+)data-bind\s*=\s*(["'])([\s\S]*?)\3/gi,
                    d = /\x3c!--\s*ko\b\s*([\s\S]*?)\s*--\x3e/g; return { Ab: function (b, c, d) { c.isTemplateRewritten(b, d) || c.rewriteTemplate(b, function (b) { return a.Ea.Lb(b, c) }, d) }, Lb: function (a, g) { return a.replace(c, function (a, c, d, f, l) { return b(l, c, d, g) }).replace(d, function (a, c) { return b(c, "\x3c!-- ko --\x3e", "#comment", g) }) }, qb: function (b, c) { return a.s.va(function (d, m) { var h = d.nextSibling; h && h.nodeName.toLowerCase() === c && a.Ka(h, b, m) }) } }
            }(); a.b("__tr_ambtns", a.Ea.qb); (function () {
            a.l = {}; a.l.i = function (a) { this.i = a }; a.l.i.prototype.text =
                function () { var b = a.a.u(this.i), b = "script" === b ? "text" : "textarea" === b ? "value" : "innerHTML"; if (0 == arguments.length) return this.i[b]; var c = arguments[0]; "innerHTML" === b ? a.a.fa(this.i, c) : this.i[b] = c }; a.l.i.prototype.data = function (b) { if (1 === arguments.length) return a.a.f.get(this.i, "templateSourceData_" + b); a.a.f.set(this.i, "templateSourceData_" + b, arguments[1]) }; a.l.Q = function (a) { this.i = a }; a.l.Q.prototype = new a.l.i; a.l.Q.prototype.text = function () {
                    if (0 == arguments.length) {
                        var b = a.a.f.get(this.i, "__ko_anon_template__") ||
                            {}; b.Fa === q && b.ma && (b.Fa = b.ma.innerHTML); return b.Fa
                    } a.a.f.set(this.i, "__ko_anon_template__", { Fa: arguments[0] })
                }; a.l.i.prototype.nodes = function () { if (0 == arguments.length) return (a.a.f.get(this.i, "__ko_anon_template__") || {}).ma; a.a.f.set(this.i, "__ko_anon_template__", { ma: arguments[0] }) }; a.b("templateSources", a.l); a.b("templateSources.domElement", a.l.i); a.b("templateSources.anonymousTemplate", a.l.Q)
            })(); (function () {
                function b(b, c, d) {
                    var f; for (c = a.e.nextSibling(c); b && (f = b) !== c;)b = a.e.nextSibling(f), 1 !==
                        f.nodeType && 8 !== f.nodeType || d(f)
                } function c(c, d) { if (c.length) { var f = c[0], g = c[c.length - 1]; b(f, g, function (b) { a.Ia(d, b) }); b(f, g, function (b) { a.s.nb(b, [d]) }) } } function d(a) { return a.nodeType ? a : 0 < a.length ? a[0] : null } function f(b, f, h, k, l) {
                    l = l || {}; var n = b && d(b), n = n && n.ownerDocument, p = l.templateEngine || g; a.Ea.Ab(h, p, n); h = p.renderTemplate(h, k, l, n); if ("number" != typeof h.length || 0 < h.length && "number" != typeof h[0].nodeType) throw Error("Template engine must return an array of DOM nodes"); n = !1; switch (f) {
                        case "replaceChildren": a.e.P(b,
                            h); n = !0; break; case "replaceNode": a.a.eb(b, h); n = !0; break; case "ignoreTargetNode": break; default: throw Error("Unknown renderMode: " + f);
                    }n && (c(h, k), l.afterRender && a.q.I(l.afterRender, null, [h, k.$data])); return h
                } var g; a.Ba = function (b) { if (b != q && !(b instanceof a.v)) throw Error("templateEngine must inherit from ko.templateEngine"); g = b }; a.za = function (b, c, h, k, l) {
                    h = h || {}; if ((h.templateEngine || g) == q) throw Error("Set a template engine before calling renderTemplate"); l = l || "replaceChildren"; if (k) {
                        var n = d(k); return a.j(function () {
                            var g =
                                c && c instanceof a.A ? c : new a.A(a.a.c(c)), r = "function" == typeof b ? b(g.$data, g) : b, g = f(k, l, r, g, h); "replaceNode" == l && (k = g, n = d(k))
                        }, null, { Qa: function () { return !n || !a.a.aa(n) }, $: n && "replaceNode" == l ? n.parentNode : n })
                    } return a.s.va(function (d) { a.za(b, c, h, d, "replaceNode") })
                }; a.Rb = function (b, d, g, k, l) {
                    function n(a, b) { c(b, r); g.afterRender && g.afterRender(b, a) } function p(c, d) { r = l.createChildContext(a.a.c(c), g.as); r.$index = d; var k = "function" == typeof b ? b(c, r) : b; return f(null, "ignoreTargetNode", k, r, g) } var r; return a.j(function () {
                        var b =
                            a.a.c(d) || []; "undefined" == typeof b.length && (b = [b]); b = a.a.Y(b, function (b) { return g.includeDestroyed || b === q || null === b || !a.a.c(b._destroy) }); a.q.I(a.a.Aa, null, [k, b, p, g, n])
                    }, null, { $: k })
                }; a.d.template = {
                    init: function (b, c) { var d = a.a.c(c()); "string" == typeof d || (d.name || 1 != b.nodeType && 8 != b.nodeType) || (d = 1 == b.nodeType ? b.childNodes : a.e.childNodes(b), d = a.a.Mb(d), (new a.l.Q(b)).nodes(d)); return { controlsDescendantBindings: !0 } }, update: function (b, c, d, f, g) {
                        c = a.a.c(c()); d = {}; f = !0; var n, p = null; "string" != typeof c && (d =
                            c, c = a.a.c(d.name), "if" in d && (f = a.a.c(d["if"])), f && "ifnot" in d && (f = !a.a.c(d.ifnot)), n = a.a.c(d.data)); "foreach" in d ? p = a.Rb(c || b, f && d.foreach || [], d, b, g) : f ? (g = "data" in d ? g.createChildContext(n, d.as) : g, p = a.za(c || b, g, d, b)) : a.e.ba(b); g = p; (n = a.a.f.get(b, "__ko__templateComputedDomDataKey__")) && "function" == typeof n.B && n.B(); a.a.f.set(b, "__ko__templateComputedDomDataKey__", g && g.ta() ? g : q)
                    }
                }; a.g.S.template = function (b) { b = a.g.da(b); return 1 == b.length && b[0].unknown || a.g.Jb(b, "name") ? null : "This template engine does not support anonymous templates nested within its templates" };
                a.e.L.template = !0
            })(); a.b("setTemplateEngine", a.Ba); a.b("renderTemplate", a.za); a.a.Pa = function () {
                function a(b, d, f, g, e) {
                    var m = Math.min, h = Math.max, k = [], l, n = b.length, p, r = d.length, q = r - n || 1, t = n + r + 1, s, v, w; for (l = 0; l <= n; l++)for (v = s, k.push(s = []), w = m(r, l + q), p = h(0, l - 1); p <= w; p++)s[p] = p ? l ? b[l - 1] === d[p - 1] ? v[p - 1] : m(v[p] || t, s[p - 1] || t) + 1 : p + 1 : l + 1; m = []; h = []; q = []; l = n; for (p = r; l || p;)r = k[l][p] - 1, p && r === k[l][p - 1] ? h.push(m[m.length] = { status: f, value: d[--p], index: p }) : l && r === k[l - 1][p] ? q.push(m[m.length] = {
                        status: g, value: b[--l],
                        index: l
                    }) : (m.push({ status: "retained", value: d[--p] }), --l); if (h.length && q.length) { b = 10 * n; var E; for (d = f = 0; (e || d < b) && (E = h[f]); f++) { for (g = 0; k = q[g]; g++)if (E.value === k.value) { E.moved = k.index; k.moved = E.index; q.splice(g, 1); d = g = 0; break } d += g } } return m.reverse()
                } return function (c, d, f) { c = c || []; d = d || []; return c.length <= d.length ? a(c, d, "added", "deleted", f) : a(d, c, "deleted", "added", f) }
            }(); a.b("utils.compareArrays", a.a.Pa); (function () {
                function b(b) {
                    for (; b.length && !a.a.aa(b[0]);)b.splice(0, 1); if (1 < b.length) {
                        for (var c =
                            b[0], g = b[b.length - 1], e = [c]; c !== g;) { c = c.nextSibling; if (!c) return; e.push(c) } Array.prototype.splice.apply(b, [0, b.length].concat(e))
                    } return b
                } function c(c, f, g, e, m) { var h = []; c = a.j(function () { var c = f(g, m, b(h)) || []; 0 < h.length && (a.a.eb(h, c), e && a.q.I(e, null, [g, c, m])); h.splice(0, h.length); a.a.R(h, c) }, null, { $: c, Qa: function () { return !a.a.pb(h) } }); return { O: h, j: c.ta() ? c : q } } a.a.Aa = function (d, f, g, e, m) {
                    function h(a, c) { u = n[c]; x !== c && (E[a] = u); u.ra(x++); b(u.O); t.push(u); w.push(u) } function k(b, c) {
                        if (b) for (var d = 0, e = c.length; d <
                            e; d++)c[d] && a.a.p(c[d].O, function (a) { b(a, d, c[d].X) })
                    } f = f || []; e = e || {}; var l = a.a.f.get(d, "setDomNodeChildrenFromArrayMapping_lastMappingResult") === q, n = a.a.f.get(d, "setDomNodeChildrenFromArrayMapping_lastMappingResult") || [], p = a.a.Z(n, function (a) { return a.X }), r = a.a.Pa(p, f, e.dontLimitMoves), t = [], s = 0, x = 0, v = [], w = []; f = []; for (var E = [], p = [], u, B = 0, y, A; y = r[B]; B++)switch (A = y.moved, y.status) {
                        case "deleted": A === q && (u = n[s], u.j && u.j.B(), v.push.apply(v, b(u.O)), e.beforeRemove && (f[B] = u, w.push(u))); s++; break; case "retained": h(B,
                            s++); break; case "added": A !== q ? h(B, A) : (u = { X: y.value, ra: a.m(x++) }, t.push(u), w.push(u), l || (p[B] = u))
                    }k(e.beforeMove, E); a.a.p(v, e.beforeRemove ? a.H : a.removeNode); for (var B = 0, l = a.e.firstChild(d), C; u = w[B]; B++) { u.O || a.a.extend(u, c(d, g, u.X, m, u.ra)); for (s = 0; r = u.O[s]; l = r.nextSibling, C = r, s++)r !== l && a.e.Va(d, r, C); !u.Fb && m && (m(u.X, u.O, u.ra), u.Fb = !0) } k(e.beforeRemove, f); k(e.afterMove, E); k(e.afterAdd, p); a.a.f.set(d, "setDomNodeChildrenFromArrayMapping_lastMappingResult", t)
                }
            })(); a.b("utils.setDomNodeChildrenFromArrayMapping",
                a.a.Aa); a.D = function () { this.allowTemplateRewriting = !1 }; a.D.prototype = new a.v; a.D.prototype.renderTemplateSource = function (b) { var c = (9 > a.a.ca ? 0 : b.nodes) ? b.nodes() : null; if (c) return a.a.N(c.cloneNode(!0).childNodes); b = b.text(); return a.a.xa(b) }; a.D.sa = new a.D; a.Ba(a.D.sa); a.b("nativeTemplateEngine", a.D); (function () {
                a.ua = function () {
                    var a = this.Ib = function () { if ("undefined" == typeof t || !t.tmpl) return 0; try { if (0 <= t.tmpl.tag.tmpl.open.toString().indexOf("__")) return 2 } catch (a) { } return 1 }(); this.renderTemplateSource =
                        function (b, f, g) { g = g || {}; if (2 > a) throw Error("Your version of jQuery.tmpl is too old. Please upgrade to jQuery.tmpl 1.0.0pre or later."); var e = b.data("precompiled"); e || (e = b.text() || "", e = t.template(null, "{{ko_with $item.koBindingContext}}" + e + "{{/ko_with}}"), b.data("precompiled", e)); b = [f.$data]; f = t.extend({ koBindingContext: f }, g.templateOptions); f = t.tmpl(e, b, f); f.appendTo(s.createElement("div")); t.fragments = {}; return f }; this.createJavaScriptEvaluatorBlock = function (a) {
                            return "{{ko_code ((function() { return " +
                                a + " })()) }}"
                        }; this.addTemplate = function (a, b) { s.write("<script type='text/html' id='" + a + "'>" + b + "\x3c/script>") }; 0 < a && (t.tmpl.tag.ko_code = { open: "__.push($1 || '');" }, t.tmpl.tag.ko_with = { open: "with($1) {", close: "} " })
                }; a.ua.prototype = new a.v; var b = new a.ua; 0 < b.Ib && a.Ba(b); a.b("jqueryTmplTemplateEngine", a.ua)
                })()
        })
    })();
})();