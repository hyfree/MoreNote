var MSG={"noTag":"Sem tag","saveSuccess":"Gravado com sucesso","none":"Nada","like":"Gostei","unlike":"Não gostei","delete":"Excluir","cancel":"Cancelar","confirm":"Confirmar","chooseReason":"Por favor selecione a razão do relatório","reportSuccess":"Relatório enviado com sucesso, iremos notificar o acordo com o autor, obrigado pela supervisão","error":"Erro","reportComment?":"Denunciar este comentário?","reportBlog?":"Denunciar este blog?","confirmDeleteComment":"Você tem certeza?","scanQRCode":"Abrir weichat e escanear o código QR","justNow":"Agota","minutesAgo":"minutos atrás","hoursAgo":"horás atrás","daysAgo":"dias atrás","weeksAgo":"semanas atrás","monthsAgo":"meses atrás"};function getMsg(key, data) {var msg = MSG[key];if(msg) {if(data) {if(!isArray(data)) {data = [data];}for(var i = 0; i < data.length; ++i) {msg = msg.replace("%s", data[i]);}}return msg;}return key;}