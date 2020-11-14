#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
}

void handleButton(){
    return ;
}
MainWindow::~MainWindow()
{
    delete ui;
}


void MainWindow::on_convertButton_clicked()
{
}
