### Install emacs

```
$ brew tap railwaycat/emacsmacport
$ brew install emacs-mac
```

### Install spacemacs

```
git clone --recursive https://github.com/syl20bnr/spacemacs ~/.emacs.d
```

### Install F# package

```
;;; ~/.emaces.d/init.el 
;;; Initialize MELPA
(require 'package)
(add-to-list 'package-archives '("melpa" . "http://melpa.milkbox.net/packages/"))
(unless package-archive-contents (package-refresh-contents))
(package-initialize)

;;; Install fsharp-mode
(unless (package-installed-p 'fsharp-mode)
  (package-install 'fsharp-mode))

(require 'fsharp-mode)
```
