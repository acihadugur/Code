from selenium import webdriver

import time

browser = webdriver.Firefox()

url = "https://getir.com/yemek/"

browser.get(url)

time.sleep(3)

giris = browser.find_element_by_xpath("(//button[@type='button'])[2]")
telefon = browser.find_element_by_xpath("//body/div[4]/div[2]/div[1]/div[2]/div[2]/form[1]/div[1]/div[1]/div[2]/div[1]/div[1]/input[1]")


giris.click()
time.sleep(3)
password.send_keys("5343557468")
time.sleep(20)

